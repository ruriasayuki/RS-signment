using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;

using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geodatabase;//嵌入互操作类型:false //IWorkspaceFactory
using ESRI.ArcGIS.Geometry;//嵌入互操作类型:false //ISpatialReferenceFactory
using ESRI.ArcGIS.DataSourcesRaster;//嵌入互操作类型:false(->RasterWorkspaceFactoryClass) //IRasterWorkspace


namespace MapControlApplication1
{
    public sealed partial class MainForm : Form
    {
        #region class private members
        private IMapControl3 m_mapControl = null;
        private string m_mapDocumentName = string.Empty;
        #endregion

        #region class constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            //get the MapControl
            m_mapControl = (IMapControl3)axMapControl1.Object;

            //disable the Save menu (since there is no document yet)
            menuSaveDoc.Enabled = false;
        }

        #region Main Menu event handlers
        private void menuNewDoc_Click(object sender, EventArgs e)
        {
            //execute New Document command
            ICommand command = new CreateNewDocument();
            command.OnCreate(m_mapControl.Object);
            command.OnClick();
        }

        private void menuOpenDoc_Click(object sender, EventArgs e)
        {
            //execute Open Document command
            ICommand command = new ControlsOpenDocCommandClass();
            command.OnCreate(m_mapControl.Object);
            command.OnClick();
        }

        private void menuSaveDoc_Click(object sender, EventArgs e)
        {
            //execute Save Document command
            if (m_mapControl.CheckMxFile(m_mapDocumentName))
            {
                //create a new instance of a MapDocument
                IMapDocument mapDoc = new MapDocumentClass();
                mapDoc.Open(m_mapDocumentName, string.Empty);

                //Make sure that the MapDocument is not readonly
                if (mapDoc.get_IsReadOnly(m_mapDocumentName))
                {
                    MessageBox.Show("Map document is read only!");
                    mapDoc.Close();
                    return;
                }

                //Replace its contents with the current map
                mapDoc.ReplaceContents((IMxdContents)m_mapControl.Map);

                //save the MapDocument in order to persist it
                mapDoc.Save(mapDoc.UsesRelativePaths, false);

                //close the MapDocument
                mapDoc.Close();
            }
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            //execute SaveAs Document command
            ICommand command = new ControlsSaveAsDocCommandClass();
            command.OnCreate(m_mapControl.Object);
            command.OnClick();
        }

        private void menuExitApp_Click(object sender, EventArgs e)
        {
            //exit the application
            Application.Exit();
        }
        #endregion

        //listen to MapReplaced evant in order to update the statusbar and the Save menu
        private void axMapControl1_OnMapReplaced(object sender, IMapControlEvents2_OnMapReplacedEvent e)
        {
            //get the current document name from the MapControl
            m_mapDocumentName = m_mapControl.DocumentFilename;

            //if there is no MapDocument, diable the Save menu and clear the statusbar
            if (m_mapDocumentName == string.Empty)
            {
                menuSaveDoc.Enabled = false;
                statusBarXY.Text = string.Empty;
            }
            else
            {
                //enable the Save manu and write the doc name to the statusbar
                menuSaveDoc.Enabled = true;
                statusBarXY.Text = System.IO.Path.GetFileName(m_mapDocumentName);
            }
        }

        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            statusBarXY.Text = string.Format("{0}, {1}  {2}", e.mapX.ToString("#######.##"), e.mapY.ToString("#######.##"), axMapControl1.MapUnits.ToString().Substring(4));
        }

        IWorkspace workspace;
        private void MI2_loadFromSDE_Click(object sender, EventArgs e)
        {
            //SDE连接数据库参数设置
            IPropertySet  propertySet  =  new  PropertySet();
            //propertySet.SetProperty("DBCLIENT","postgresql");
            //propertySet.SetProperty("DB_CONNECTION_PROPERTIES","localhost");//主机名或者端口
            propertySet.SetProperty("SERVER","localhost"); 
            propertySet.SetProperty ("INSTANCE","sde:oracle11g:localhost/orcl"); 
            propertySet.SetProperty ("DATABASE" , "sde1363" ); 
            propertySet.SetProperty ("USER" , "sde" );
            propertySet.SetProperty("PASSWORD", "123456");
            propertySet.SetProperty("VERSION", "sde.DEFAULT");
            propertySet.SetProperty("AUTHENTICATION_MODE", "DBMS");

            //----- 连接 SDE 数据库 -----//
            //指定SDE工作空间factory
            Type factoryType = Type. GetTypeFromProgID ("esriDataSourcesGDB.SdeWorkspaceFactory");
            IWorkspaceFactory workspaceFactory = (IWorkspaceFactory)Activator.CreateInstance(factoryType);
            //根据SDE连接参数设置打开SDE工作空间
            //set the private property -- workspace
            workspace = workspaceFactory.Open(propertySet, 0);

            //----- 初始化加载栅格目录下拉框内容 -----//
            //清除栅格目录下拉框里面的选项
            //“加载栅格图像”中的栅格目录
            cmb_loadRstCatalog.Items.Clear();
            cmb_loadRstCatalog.Text = "";
            cmb_loadRstCatalog.Items.Add("非栅格目录(工作空间)");
            //“导入栅格图像”中的栅格目录
            cmb_importRstCatalog.Items.Clear();
            cmb_loadRstCatalog.Text = "";
            cmb_importRstCatalog.Items.Add("非栅格目录(工作空间)");

            //获取数据库中的栅格目录，去除SDE前缀
            IEnumDatasetName enumDatasetName  = workspace.get_DatasetNames(esriDatasetType. esriDTRasterCatalog); 
            IDatasetName datasetName  =  enumDatasetName.Next(); 
            while(datasetName != null)
            {
                cmb_loadRstCatalog.Items.Add(datasetName.Name.Substring(datasetName.Name.LastIndexOf(".")+1)) ; 
                //cmb_rstImgs.Items.Add(datasetName.Name.Substring(datasetName.Name.LastIndexOf(".")+1)); 
                datasetName = enumDatasetName.Next(); 
            }
            //设置下拉框默认选项为非栅格目录(工作空间)
            //“加载栅格图像”中的栅格目录
            if (cmb_loadRstCatalog.Items.Count > 0)
            {
                cmb_loadRstCatalog.SelectedIndex = 0;
            }
            //“导入栅格图像”中的栅格目录
            if (cmb_importRstCatalog.Items.Count > 0)
            {
                cmb_importRstCatalog.SelectedIndex = 0;
            }

        }

        //----- 栅格目录和栅格图像下拉框内容实现联动 -----//
        private void cmb_rstCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rstCatalogName = cmb_loadRstCatalog.SelectedItem.ToString();
            IEnumDatasetName enumDatasetName;
            IDatasetName datasetName;
            if (cmb_loadRstCatalog.SelectedIndex == 0)
            {
                //清除栅格图像下拉框里面的选项
                cmb_loadRstDataset.Items.Clear();
                cmb_loadRstDataset.Text = "";
                //获取非栅格目录(工作空间)中的栅格图像
                enumDatasetName = workspace.get_DatasetNames(esriDatasetType.esriDTRasterDataset);
                datasetName = enumDatasetName.Next();
                while (datasetName != null)
                {
                    cmb_loadRstDataset.Items.Add(datasetName.Name.Substring(datasetName.Name.LastIndexOf(".") + 1));
                    datasetName = enumDatasetName.Next();
                }
                //设置下拉框默认选项为非栅格目录(工作空间）
                if (cmb_loadRstDataset.Items.Count > 0)
                    cmb_loadRstDataset.SelectedIndex = 0;
            }
            else
            {
                //接口转换IRasterWorkspaceEx
                IRasterWorkspaceEx workspaceEx = (IRasterWorkspaceEx)workspace;
                //获取栅格目录
                IRasterCatalog rasterCatalog = workspaceEx.OpenRasterCatalog(rstCatalogName); 
                //接口转换IFeatureClass
                IFeatureClass featureClass = (IFeatureClass)rasterCatalog; 
                //接口转换ITable
                ITable pTable = featureClass as ITable; 
                //执行查询获取指针
                ICursor cursor = pTable.Search(null,  true)  as  ICursor; 
                IRow pRow = null;
                //清除下拉框的选项
                cmb_loadRstDataset.Items.Clear();
                cmb_loadRstDataset.Text = "";
                //循环遍历读取每一行记录
                while ((pRow = cursor.NextRow()) != null)
                {
                    int idxName = pRow.Fields.FindField ("NAME");
                    cmb_loadRstDataset.Items.Add(pRow.get_Value (idxName).ToString()); 
                }
                //设置默认选项
                if (cmb_loadRstDataset.Items.Count > 0)
                {
                    cmb_loadRstDataset.SelectedIndex = 0;
                }
                //释放内存空间
                System.Runtime.InteropServices.Marshal.ReleaseComObject(cursor) ; 
            }
        }

        //***** 数据处理->创建栅格目录 *****//
        //----- 创建栅格目录，默认采用WGS84投影 -----//
        private void btn_createRstCat_Click(object sender, EventArgs e)
        {
            if (txb_newRstCat.Text.Trim() == "")
                MessageBox.Show("请输入栅格目录名称!");
            else
            {
                string  rasCatalogName = txb_newRstCat.Text.Trim();
                IRasterWorkspaceEx rasterWorkspaceEx = workspace as IRasterWorkspaceEx;
                //定义空间参考采用WGS84投影
                ISpatialReferenceFactory spatialReferenceFactory = new SpatialReferenceEnvironmentClass();
                ISpatialReference spatialReference = spatialReferenceFactory.CreateGeographicCoordinateSystem((int)esriSRGeoCSType.esriSRGeoCS_WGS1984);
                spatialReference.SetDomain(-180, 180, -90, 90); 
                //判断栅格目录是否存在
                IEnumDatasetName enumDatasetName = workspace.get_DatasetNames(esriDatasetType.esriDTRasterCatalog);
                IDatasetName datasetName = enumDatasetName.Next();
                bool isExit = false;
                //循环遍历判断是否已存在该栅格目录
                while (datasetName != null)
                {
                    if(datasetName.Name.Substring(datasetName. Name. LastIndexOf (".")+1) == rasCatalogName)
                    {
                        isExit = true;
                        MessageBox.Show("栅格目录己经存在!");
                        txb_newRstCat.Focus();
                        return;
                    }
                    datasetName = enumDatasetName.Next(); 
                }

                //若不存在，则创建新的栅格目录
                if (isExit == false)
                {
                    //创建栅格目录字段集
                    IFields fields = CreateFields("RASTER","SHAPE",spatialReference,spatialReference); //CreateFields函数见下
                    rasterWorkspaceEx.CreateRasterCatalog(rasCatalogName,fields,"SHAPE","RASTER","DEFAULTS"); 
                    //将新创建的栅格目录添加到下拉列表中，并设置为当前栅格目录
                    //cmb_LoadRstCatalog. Items.Add(rasCatalogName); 
                    //cmb_LoadRstCatalog.SelectedIndex  =  cmb_LoadRstCatalog.Items.Count - 1 ; 
                    cmb_loadRstCatalog.Items.Add(rasCatalogName); 
                    cmb_loadRstCatalog.SelectedIndex = cmb_loadRstCatalog.Items.Count - 1;
                    cmb_loadRstDataset.Items.Clear(); 
                    cmb_loadRstDataset.Text  = "";
                } 
                MessageBox.Show("栅格目录创建成功!");
            }
        }

        /// <summary>
        ///----- 创建栅格目录所需的字段集 -----// 
        /// </summary>
        /// <param name="rarasterFldName">Raster字段名称</param>
        /// <param name="shapeFldName">Shape字段名称</param>
        /// <param name="rarasterSF">Raster字段的空间参考</param>
        /// <param name="shapeSF">Shape字段的空间参考</param>
        private IFields CreateFields(string rasterFldName, string shapeFldName, ISpatialReference rasterSF, ISpatialReference shapeSF)
        {
            IFields fields  =  new  FieldsClass();
            IFieldsEdit fieldsEdit = fields as IFieldsEdit;
            IField field;
            IFieldEdit fieldEdit; 

            //添加OID字段，注意字段type
            field =  new  FieldClass(); 
            fieldEdit  =  field  as  IFieldEdit;
            fieldEdit.Name_2  = "ObjectID";
            fieldEdit.Type_2  =  esriFieldType.esriFieldTypeOID; 
            fieldsEdit.AddField(field);

            //添加name字段，注意字段type
            field = new FieldClass();
            fieldEdit = field as IFieldEdit;
            fieldEdit.Name_2 = "NAME";
            fieldEdit.Type_2 = esriFieldType.esriFieldTypeString;
            fieldsEdit.AddField(field) ; 
            
            //添加raster字段，注意字段type
            field = new FieldClass();
            fieldEdit = field as IFieldEdit;
            fieldEdit.Name_2 = rasterFldName;
            fieldEdit.Type_2 = esriFieldType.esriFieldTypeRaster;

            //IRasterDef接口定义栅格字段
            IRasterDef rasterDef = new RasterDefClass();
            rasterDef.SpatialReference = rasterSF;
            ((IFieldEdit2)fieldEdit).RasterDef = rasterDef;
            fieldsEdit.AddField(field);

            //添加shape字段，注意字段type
            field = new FieldClass();
            fieldEdit = field as IFieldEdit;
            fieldEdit.Name_2 = shapeFldName; 
            fieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry; 
            
            //IGeometryDef和IGeometryDefEdit接口定义和编辑几何字段
            IGeometryDef geometryDef = new GeometryDefClass();
            IGeometryDefEdit geometryDefEdit = geometryDef as IGeometryDefEdit;
            geometryDefEdit.GeometryType_2 = esriGeometryType. esriGeometryPolygon;
            geometryDefEdit.SpatialReference_2 = shapeSF;
            ((IFieldEdit2)fieldEdit).GeometryDef_2 = geometryDef;
            fieldsEdit.AddField(field); 

            //添加xml(元数据)字段，注意字段type
            field = new FieldClass();
            fieldEdit = field as IFieldEdit;
            fieldEdit.Name_2 = "METADATA";
            fieldEdit.Type_2 = esriFieldType.esriFieldTypeBlob;
            fieldsEdit.AddField(field);
            
            return fields; 
        }

        //***** 数据处理->加载栅格图像 *****//
        //----- 根据选定的栅格目录和栅格图像,加载相应的栅格图像 -----//
        private void btn_loadRstDataset_Click(object sender, EventArgs e)
        {
            if (cmb_loadRstCatalog.SelectedIndex == 0)
            {
                string rstDatasetName = cmb_loadRstDataset.SelectedItem.ToString();
                //接口转换IRasterWorkspaceEx
                IRasterWorkspaceEx workspaceEx = (IRasterWorkspaceEx)workspace;
                //获取栅格数据集
                IRasterDataset rasterDataset = workspaceEx.OpenRasterDataset(rstDatasetName);
                //利用栅格目录项创建栅格图层
                IRasterLayer rasterLayer = new RasterLayerClass(); //IRasterLayer:引入DataSourceRaster
                rasterLayer.CreateFromDataset(rasterDataset);
                ILayer layer = rasterLayer as ILayer;
                //将图层加载至MapControl中，并缩放到当前图层
                axMapControl1.AddLayer(layer);
                axMapControl1.ActiveView.Extent = layer.AreaOfInterest;
                axMapControl1.ActiveView.Refresh();
                axTOCControl1.Update();
            }
            else
            {
                string rstCatalogName = cmb_loadRstCatalog.SelectedItem.ToString();
                String rstDatasetName = cmb_loadRstDataset.SelectedItem.ToString();
                //接口转换IRasterWorkspaceEx
                IRasterWorkspaceEx workspaceEx = (IRasterWorkspaceEx) workspace; 
                //获取栅格目录
                IRasterCatalog rasterCatalog = workspaceEx.OpenRasterCatalog(rstCatalogName);
                //接口转换IFeatureClass
                IFeatureClass featureClass = (IFeatureClass)rasterCatalog;
                //接口转换ITable
                ITable pTable = featureClass as ITable;
                //查询条件过滤器QueryFilterClass
                IQueryFilter qf = new QueryFilterClass();
                qf.SubFields = "OBJECTID";
                qf.WhereClause = "NAME='" + rstDatasetName + "'";
                //执行查询获取指针
                ICursor cursor = pTable.Search(qf, true) as ICursor;
                IRow pRow = null;
                int rstOID = 0;
                //判断读取第一行记录
                if ((pRow = cursor.NextRow()) != null)
                {
                    int idxfld = pRow.Fields.FindField("OBJECTID"); 
                    rstOID = int. Parse (pRow.get_Value(idxfld).ToString());
                    //获取检索到的栅格目录项
                    IRasterCatalogItem rasterCatalogltem = (IRasterCatalogItem)featureClass.GetFeature(rstOID);
                    //利用栅格目录项创建栅格图层
                    IRasterLayer rasterLayer = new RasterLayerClass();
                    rasterLayer.CreateFromDataset(rasterCatalogltem.RasterDataset);
                    ILayer layer = rasterLayer as ILayer;
                    //将图层加载至MapControl中，并缩放到当前图层
                    axMapControl1.AddLayer(layer);
                    axMapControl1.ActiveView.Extent = layer.AreaOfInterest;
                    axMapControl1.ActiveView.Refresh();
                    axTOCControl1.Update(); 
                }
                //释放内存空间
                System.Runtime.InteropServices.Marshal.ReleaseComObject(cursor); 
            }
            iniCmbItems();
        }

        //***** 数据处理->导入栅格图像 *****//
        //----- 点击栅格图像弹出文件选择对话框，选择要导入的栅格图像 -----//
        private void txb_importRstDataset_Click(object sender, EventArgs e)
        {
            //打开文件选择对话框，设置对话框属性
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imag file(*.img)|*.img|Tiff file(*.tif)|*.tif";
            openFileDialog.Title = "打开影像数据";
            openFileDialog.Multiselect = false;
            string fileName = "";
            //如果对话框己成功选择文件，将文件路径信息填写到输入框里
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                txb_importRstDataset.Text = fileName;
            }
        }

        //----- 点击导入，把选择的栅格图像导入工作空间或指定的栅格目录 -----//
        private void btn_importRstDataset_Click(object sender, EventArgs e)
        {
            //获取栅格图像的路径和文件名字
            string fileName = txb_importRstDataset.Text; 
            FileInfo filelnfo = new FileInfo(fileName); 
            string filePath = filelnfo.DirectoryName; 
            string file = filelnfo. Name;
            string strOutName = file.Substring(0, file.LastIndexOf("."));
            //根据路径和文件名字获取栅格数据集
            if (cmb_importRstCatalog.SelectedIndex == 0)
            {
                //判断是否有重名现象
                IWorkspace2 workspace2 = workspace as IWorkspace2;
                //如果名称己存在
                if (workspace2.get_NameExists(esriDatasetType.esriDTRasterDataset, strOutName))
                {
                    DialogResult result;
                    result = MessageBox.Show(this, "名为 " + strOutName + " 的栅格文件在数据库中己存在！" + "＼n是否覆盖？",
                        "相同文件名", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    //如果选择确认删除，则覆盖原栅格数据
                    if (result == DialogResult.Yes)
                    {
                        IRasterWorkspaceEx rstWorkspaceEx = workspace as IRasterWorkspaceEx;
                        IDataset datasetDel = rstWorkspaceEx.OpenRasterDataset(strOutName) as IDataset;
                        //调用IDataset接口的Delete接口实现己存在栅格数据集的删除
                        datasetDel.Delete();
                        datasetDel = null;
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("工作空间己存在同名栅格数据集，不覆盖不能导入！");
                        return;
                    }
                }
                //根据选择的栅格图像的路径打开栅格工作空间
                IWorkspaceFactory rstWorkspaceFactoryImport = new RasterWorkspaceFactoryClass();
                IRasterWorkspace rstWorkspacelmport = (IRasterWorkspace)rstWorkspaceFactoryImport.OpenFromFile(filePath, 0);
                IRasterDataset rstDatasetlmport = null;
                //检测选择文件的路径是不是有效的栅格工作空间
                if (!(rstWorkspacelmport is IRasterWorkspace))
                {
                    MessageBox.Show("文件路径不是有效的栅格工作空间！");
                    return;
                }
                //根据选择的栅格图像的名字获取栅格数据集
                rstDatasetlmport = rstWorkspacelmport.OpenRasterDataset(file);

                //用IRasterDataset接口的CreateDefaultRaster方法创建空白的栅格对象
                IRaster raster = rstDatasetlmport.CreateDefaultRaster();
                //IRasterProps 是和栅格属性定义有关的接口
                IRasterProps rasterProp = raster as IRasterProps;

                //IRasterStor吨eDef接口和栅格储存参数有关
                IRasterStorageDef storageDef = new RasterStorageDefClass();
                //指定压缩类型
                storageDef.CompressionType = esriRasterCompressionType.esriRasterCompressionLZ77;
                //设置CellSize
                IPnt pnt = new PntClass();
                pnt.SetCoords(rasterProp.MeanCellSize().X, rasterProp.MeanCellSize().Y);
                storageDef.CellSize = pnt;
                //设置栅格数据集的原点，在最左上角一点位置。
                IPoint origin = new PointClass();
                origin.PutCoords(rasterProp.Extent.XMin, rasterProp.Extent.YMax);
                storageDef.Origin = origin;

                //接口转换为和栅格存储有关的ISaveAs2
                ISaveAs2 saveAs2 = (ISaveAs2)rstDatasetlmport;

                //接口转换为和栅格存储属性定义有关的IRasterStorageDef2
                IRasterStorageDef2 rasterStorageDef2 = (IRasterStorageDef2)storageDef;
                //指定压缩质量，瓦片高度和宽度
                rasterStorageDef2.CompressionQuality = 100;
                rasterStorageDef2.Tiled = true;
                rasterStorageDef2.TileHeight = 128;
                rasterStorageDef2.TileWidth = 128;
                //最后调用 ISaveAs2接口的SaveAsRasterDataset方法实现栅格数据集的存储
                //指定存储名字，工作空间，存储格式和相关存储属性
                saveAs2.SaveAsRasterDataset(strOutName, workspace, "GRID", rasterStorageDef2);

                //显示导入成功的消息
                MessageBox.Show("导入成功！");
            }
            else
            {
                string  rasterCatalogName  =  cmb_importRstCatalog.Text;
                //打开栅格工作空间
                IWorkspaceFactory pRasterWsFac = new  RasterWorkspaceFactoryClass();
                IWorkspace pWs = pRasterWsFac.OpenFromFile(filePath, 0);
                if (!(pWs is IRasterWorkspace))
                {
                    MessageBox.Show("文件路径不是有效的栅格工作空间！");
                    return; 
                }
                IRasterWorkspace pRasterWs = pWs as IRasterWorkspace;
                //获取栅格数据集
                IRasterDataset pRasterDs = pRasterWs.OpenRasterDataset(file);
                //创建栅格对象
                IRaster raster = pRasterDs.CreateDefaultRaster();
                IRasterProps rasterProp = raster as IRasterProps;
 
                //设置栅格储存参数
                IRasterStorageDef storageDef = new RasterStorageDefClass();
                storageDef.CompressionType = esriRasterCompressionType.esriRasterCompressionLZ77;
                //设置CellSize
                IPnt pnt = new PntClass();
                pnt.SetCoords(rasterProp. MeanCellSize().X, rasterProp.MeanCellSize().Y);
                storageDef.CellSize = pnt;
                //设置栅格数据集的原点，在最左上角一点位置。
                IPoint origin = new PointClass();
                origin.PutCoords(rasterProp.Extent.XMin, rasterProp.Extent.YMax);
                storageDef.Origin =origin; 

                //在Raster Catalog 中添加栅格
                //打开对应的Raster Catalog
                IRasterCatalog pRasterCatalog = ((IRasterWorkspaceEx)workspace).OpenRasterCatalog(rasterCatalogName);
                //将需要导入的RasterCatalog转换成为FeatureClass
                IFeatureClass pFeatureClass = (IFeatureClass)pRasterCatalog;
                //名字所在列的索引号
                int nameIndex = pRasterCatalog.NameFieldIndex;
                //栅格数据所在列的索引号
                int rasterIndex = pRasterCatalog.RasterFieldIndex;
                IFeatureBuffer pBuffer = null;
                IFeatureCursor pFeatureCursor = pFeatureClass.Insert(false);
                //创建IRasterValue接口的对象:RasterBuffer对象的rasterIndex需要使用
                IRasterValue pRasterValue = new RasterValueClass();
                //设置IRasterValue 的RasterDataset
                pRasterValue.RasterDataset = (IRasterDataset)pRasterDs;
                //存储参数设定
                pRasterValue.RasterStorageDef = storageDef;
                pBuffer = pFeatureClass.CreateFeatureBuffer();
                //设置RasterBuffer对象的rasterIndex和nameIndex
                pBuffer.set_Value(rasterIndex, pRasterValue);
                pBuffer.set_Value(nameIndex, strOutName);
                //通过cursor实现feature 的insert操作
                pFeatureCursor.InsertFeature(pBuffer);
                pFeatureCursor.Flush();
                //释放内存资源
                System.Runtime.InteropServices.Marshal.ReleaseComObject(pBuffer);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(pRasterValue);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(pFeatureCursor);
                //显示成功信息
                MessageBox.Show("导入成功！");
            }
        }

        //***** TOCControl控件的鼠标点击事件 *****//
        //----- 鼠标点击时判断是右键则弹出菜单 -----//
        ILayer TOCRightLayer;
        private void axTOCControl1_OnMouseDown(object sender, ITOCControlEvents_OnMouseDownEvent e)
        {
            try
            {
                //获取当前鼠标点击位置的相关信息
                esriTOCControlItem itemType = esriTOCControlItem.esriTOCControlItemNone;
                IBasicMap basicMap = null;
                ILayer layer = null;
                object unk = null;
                object data = null;

                //将以上定义的接口对象作为引用传入函数中，获取多个返回值
                this.axTOCControl1.HitTest(e.x, e.y, ref itemType, ref basicMap, ref layer, ref unk, ref data);

                //如果是鼠标右击且点击位置为图层，则弹出右击功能框
                if (e.button == 2 && itemType == esriTOCControlItem.esriTOCControlItemLayer)
                {
                    //设置TOC选择图层
                    this.TOCRightLayer = layer;
                    this.cms_TOCRightMenu.Show(axTOCControl1, e.x, e.y); 
                }
            }
            catch (System.Exception ex)//异常处理，输出错误信息
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----- 右键菜单->缩放到当前图层 -----//
        private void tsmi_zoomToLayer_Click(object sender, EventArgs e)
        {
            try
            {
                //缩放到当前图层
                axMapControl1.ActiveView.Extent = TOCRightLayer.AreaOfInterest;
                //刷新页面显示
                axMapControl1.ActiveView.Refresh();
            }
            catch (System.Exception ex)//异常处理，输出错误信息
            { 
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----- 右键菜单->删除当前图层 -----//
        private void tsmi_deleteLayer_Click(object sender, EventArgs e)
        {
            try
            {
                //删除当前图层
                axMapControl1.Map.DeleteLayer(TOCRightLayer);
                //刷新当前页面
                axMapControl1.ActiveView.Refresh();
                //更新波段信息统计的图层和波段下拉框选项内容
                iniCmbItems();
            }
            catch (System.Exception ex)//异常处理，输出错误信息
            { 
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //===== 图层和波段选择下拉框的初始化和联动变化 =====//
        //-----  初始化函数 -----//
        //加载图层时，初始化“图像处理”tab页里的图层和波段下拉框的选项内容
        private void iniCmbItems()
        {
            try
            {
                //清除波段信息统计图层下拉框的选项内容
                cmb_statisticsLayer.Items.Clear();
                //消除NDVI指数计算图层下拉框的选项内容
                cmb_ndviLayer.Items.Clear();
                //清除直方图绘制图层下拉框的选项内容
                cmb_drawHisLayer.Items.Clear();
                //清除单波段灰度增强的图层下拉框的选项内容
                cmb_stretchLayer.Items.Clear();
                //消除单波段伪彩色渲染的图层下拉框的选项内容
                cmb_renderLayer.Items.Clear();
                //清除多波段假彩色合成的图层下拉框的选项内容
                cmb_rgbLayer.Items.Clear();
                ILayer layer = null;
                IMap map = axMapControl1.Map; 
                int count = map.LayerCount;
                if (count > 0)
                {
                    //遍历地图的所有图层，获取图层名字加入下拉框
                    for (int i = 0; i < count; i++) 
                    {
                        layer = map.get_Layer(i);
                        //波段信息统计的图层下拉框
                        cmb_statisticsLayer.Items.Add(layer.Name);
                        //NDVI指数计算的图层下拉框
                        cmb_ndviLayer.Items.Add(layer.Name);
                        //直方图绘制的图层下拉框
                        cmb_drawHisLayer.Items.Add(layer.Name);
                        //单波段灰度增强的图层下拉框
                        cmb_stretchLayer.Items.Add(layer.Name);
                        //单波段伪彩色渲染的图层下拉框
                        cmb_renderLayer.Items.Add(layer.Name); 
                        //多波段假彩色合成的图层下拉框
                        cmb_rgbLayer. Items.Add(layer.Name);
                    }
                    //设置下拉框默认选项为第一个图层
                    if (cmb_statisticsLayer.Items.Count > 0) 
                    {
                        cmb_statisticsLayer.SelectedIndex = 0; 
                    }
                    if (cmb_ndviLayer.Items.Count > 0)
                    {
                        cmb_ndviLayer.SelectedIndex = 0;
                    }
                    if (cmb_drawHisLayer.Items.Count > 0)
                    {
                        cmb_drawHisLayer.SelectedIndex = 0;
                    }
                    if (cmb_stretchLayer.Items.Count > 0)
                    {
                        cmb_stretchLayer.SelectedIndex = 0;
                    }
                    if (cmb_renderLayer.Items.Count > 0)
                    {
                        cmb_renderLayer.SelectedIndex = 0;
                    }
                    if (cmb_rgbLayer.Items.Count > 0)
                    {
                        cmb_rgbLayer.SelectedIndex = 0;
                    }

                    //清除波段信息统计波段下拉框的选项内容
                    cmb_statisticsBand.Items.Clear();
                    //消除直方图绘制的波段下拉框的选项内容
                    cmb_drawHisBand.Items.Clear();
                    //清除单波段灰度增强的波段下拉框的选项内容
                    cmb_stretchBand.Items.Clear(); 
                    //清除单波段伪彩色渲染的波段下拉框的选项内容
                    cmb_renderBand.Items.Clear(); 
                    //清除多波段假彩色合成的波段下拉框的选项内容
                    cmb_RBand.Items.Clear();
                    cmb_GBand.Items.Clear();
                    cmb_BBand.Items.Clear(); 
                    //获取第1个图层的栅格波段
                    IRasterLayer rstLayer = map.get_Layer(0) as IRasterLayer;
                    IRaster2 raster2  = rstLayer.Raster as IRaster2; 
                    IRasterDataset rstDataset = raster2.RasterDataset;
                    IRasterBandCollection rstBandColl = rstDataset as IRasterBandCollection;
                    //波段总数
                    int bandCount = rstLayer.BandCount; 
                    //添加所有波段的选项
                    cmb_statisticsBand.Items.Add("全部波段");
                    //遍历图层的所有波段，获取波段名字加入下拉框
                    for (int i = 0; i < bandCount; i++)
                    {
                        int bandIdx = i + 1; //设置波段序号
                        //添加波段信息统计的波段下拉框的选项内容
                        cmb_statisticsBand.Items.Add ( "波段" + bandIdx);
                        //添加直方图绘制的波段下拉框的选项内容
                        cmb_drawHisBand.Items.Add ( "波段" + bandIdx);
                        //添加单波段灰度增强的波段下拉框的选项内容
                        cmb_stretchBand.Items.Add ( "波段" + bandIdx);
                        //添加单波段伪彩色渲染的波段下拉框的选项内容
                        cmb_renderBand.Items.Add ( "波段" + bandIdx);
                        //添加多波段假彩色合成的波段下拉框的选项内容
                        cmb_RBand.Items.Add("波段" + bandIdx);
                        cmb_GBand.Items.Add("波段" + bandIdx);
                        cmb_BBand.Items.Add("波段" + bandIdx);
                    }
                    //设置下拉框默认选项
                    if (cmb_statisticsBand.Items.Count > 0)
                    {
                        cmb_statisticsBand.SelectedIndex = 0;
                    }
                    if (cmb_drawHisBand.Items.Count > 0)
                    {
                        cmb_drawHisBand.SelectedIndex = 0;
                    }
                    if (cmb_stretchBand.Items.Count > 0)
                    {
                        cmb_stretchBand.SelectedIndex = 0;
                    }
                    if (cmb_renderBand.Items.Count > 0)
                    {
                        cmb_renderBand.SelectedIndex = 0;
                    }
                    if (cmb_RBand.Items.Count > 0)
                    {
                        cmb_RBand.SelectedIndex = 0;
                    }
                    if (cmb_GBand.Items.Count > 0)
                    {
                        cmb_GBand.SelectedIndex = 0;
                    }
                    if (cmb_BBand.Items.Count > 0)
                    {
                        cmb_BBand.SelectedIndex = 0;
                    }
                }
            }
            catch (System.Exception ex)//异常处理，输出错误信息
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-----  联动变化函数  -----//
        //。。。。。 自己写 。。。。。//
        //当遥感图像处理分析的图层下拉框的选择项发生变化，则相应的波段下拉框的选项也会发生变化
        private void selectedIndexChangeFunction(ComboBox cmbLayer, ComboBox ctnbBand, string type)
        {
            try
            {
                //。。。。。 自己写 。。。。。//
                //获取图层的栅格波段
                IMap map = axMapControl1.Map;
                int layerCount = map.LayerCount;
                IRasterLayer rstLayer = null;
                //根据图层名获取图层
                for (int i = 0; i < layerCount; i++)
                {
                    IRasterLayer tmpLayer = map.get_Layer(i) as IRasterLayer;
                    if (tmpLayer.Name == cmbLayer.Text)
                    {
                        rstLayer = tmpLayer;
                        break;
                    }
                }
                //获取该图层中的波段
                if (rstLayer != null)
                {
                    //清除波段下拉框中已有的选项
                    ctnbBand.Items.Clear();
                    ctnbBand.Text = "";
                    //获取栅格图层光谱波段集合
                    IRaster2 raster2 = rstLayer.Raster as IRaster2;
                    IRasterDataset rstDataset = raster2.RasterDataset;
                    IRasterBandCollection rstBandColl = rstDataset as IRasterBandCollection;

                    //遍历所有波段
                    int bandCount = rstLayer.BandCount;//波段总数
                    for (int j = 0; j < bandCount; j++)
                    {
                        //IRasterBand rb = rstBandColl.Item(j); //获取波段
                        int bandIdx = j + 1; //设置波段序号
                        //添加波段下拉框的选项内容
                        ctnbBand.Items.Add("波段" + bandIdx);
                    }
                }
               
            }
            catch (System.Exception ex)//异常处理，输出错误信息
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-----  图层下拉框的选择变化触发事件 -----//
        //当波段信息的图层下拉框的选择项发生变化，则相应的波段下拉框的选择项也发生变化
        private void cmb_statisticsLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedIndexChangeFunction(cmb_statisticsLayer, cmb_statisticsBand, "statistics");
            }
            catch (System. Exception ex) //异常处理，输出错误信息
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //当直方图绘制的图层下拉框的选择项发生变化，则相应的波段下拉框的选择项也发生变化
        private void cmb_drawHisLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedIndexChangeFunction(cmb_drawHisLayer, cmb_statisticsBand, null);
            }
            catch (System.Exception ex) //异常处理，输出错误信息
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //当单波段灰度增强的图层下拉框的选择项发生变化，则相应的波段下拉框的选择项也发生变化
        private void cmb_stretchLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedIndexChangeFunction(cmb_stretchLayer, cmb_statisticsBand, null);
            }
            catch (System.Exception ex) //异常处理，输出错误信息
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //当单波段伪彩色渲染的图层下拉框的选择项发生变化，则相应的波段下拉框的选择项也发生变化
        private void cmb_renderLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedIndexChangeFunction(cmb_renderLayer, cmb_statisticsBand, null);
            }
            catch (System.Exception ex) //异常处理，输出错误信息
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //当多波段假彩色合成的图层下拉框的选择项发生变化，则相应的波段下拉框的选择项也发生变化
        private void cmb_rgbLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedIndexChangeFunction(cmb_rgbLayer, cmb_RBand, null);
                selectedIndexChangeFunction(cmb_rgbLayer, cmb_GBand, null);
                selectedIndexChangeFunction(cmb_rgbLayer, cmb_BBand, null);
            }
            catch (System.Exception ex) //异常处理，输出错误信息
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //===== 波段信息统计 =====//
        //。。。。。 自己写 。。。。。//
        //->第8页
        /// <summary>
        /// 波段信息统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e”></param>
        private void btn_statistics_Click(object sender, EventArgs e)
        {
            try
            {
                IMap map = axMapControl1.Map;
                int layerCount = map.LayerCount;
                IRasterLayer rstLayer = null;
                //根据图层名获取图层
                for (int i = 0; i < layerCount; i++)
                {
                    IRasterLayer tmpLayer = map.get_Layer(i) as IRasterLayer;
                    if (tmpLayer.Name == cmb_statisticsLayer.Text)
                    {
                        rstLayer = tmpLayer;
                        break;
                    }
                }
                //获取栅格图层光谱波段集合
                IRaster2 raster2 = rstLayer.Raster as IRaster2;
                IRasterDataset rstDataset = raster2.RasterDataset;
                IRasterBandCollection rstBandColl = rstDataset as IRasterBandCollection;
                
                //遍历所有波段
                int bandCount = rstLayer.BandCount;//波段总数
                for (int i = 0; i < bandCount; i++)
                {
                    IRasterBand rasterBand = rstBandColl.Item(i); //获取波段
                }
            }
            finally
            {
            }
        }

        private void btn_blueAnalyse_Click(object sender, EventArgs e)
        {
            try
            {
                IMap map = axMapControl1.Map;
                int layerCount = map.LayerCount;
                IRasterLayer rstLayer = null;
                //根据图层名获取图层
                for (int i = 0; i < layerCount; i++)
                {
                    IRasterLayer tmpLayer = map.get_Layer(i) as IRasterLayer;
                    if (tmpLayer.Name == cmb_statisticsLayer.Text)
                    {
                        rstLayer = tmpLayer;
                        break;
                    }
                }
                //获取栅格图层光谱波段集合
                IRaster2 raster2 = rstLayer.Raster as IRaster2;
                IRasterDataset rstDataset = raster2.RasterDataset;
                IRasterBandCollection rstBandColl = rstDataset as IRasterBandCollection;

                //遍历所有波段
                int bandCount = rstLayer.BandCount;//波段总数
                for (int i = 0; i < bandCount; i++)
                {
                    IRasterBand rasterBand = rstBandColl.Item(i); //获取波段
                }

            }
            finally
            {
            }
        }
        


    }    
}
#pragma warning disable 1591

namespace kp2_2 {
    
    
    /// <summary>
    ///Represents a strongly typed in-memory cache of data.
    ///</summary>
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("кп2_DataSet")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class кп2_DataSet : global::System.Data.DataSet {
        
        private РасписаниеDataTable tableРасписание;
        
        private СеткиDataTable tableСетки;
        
        private Списки_участниковDataTable tableСписки_участников;
        
        private Справочник_игроковDataTable tableСправочник_игроков;
        
        private Справочник_катерогийDataTable tableСправочник_катерогий;
        
        private Справочник_кортовDataTable tableСправочник_кортов;
        
        private Справочник_систем_проведенияDataTable tableСправочник_систем_проведения;
        
        private Справочник_этапов_турнираDataTable tableСправочник_этапов_турнира;
        
        private ТурнирыDataTable tableТурниры;
        
        private global::System.Data.DataRelation relationСеткиРасписание;
        
        private global::System.Data.DataRelation relationТурнирыРасписание;
        
        private global::System.Data.DataRelation relationСправочник_этапов_турнираСетки;
        
        private global::System.Data.DataRelation relationТурнирыСетки;
        
        private global::System.Data.DataRelation relationСправочник_игроковСписки_участников;
        
        private global::System.Data.DataRelation relationСправочник_игроковСписки_участников1;
        
        private global::System.Data.DataRelation relationТурнирыСписки_участников;
        
        private global::System.Data.DataRelation relationСправочник_систем_проведенияСправочник_этапов_турнира;
        
        private global::System.Data.DataRelation relationСправочник_катерогийТурниры;
        
        private global::System.Data.DataRelation relationСправочник_кортовТурниры;
        
        private global::System.Data.DataRelation relationСправочник_кортовТурниры1;
        
        private global::System.Data.DataRelation relationСправочник_кортовТурниры2;
        
        private global::System.Data.DataRelation relationСправочник_систем_проведенияТурниры;
        
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public кп2_DataSet() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected кп2_DataSet(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["Расписание"] != null)) {
                    base.Tables.Add(new РасписаниеDataTable(ds.Tables["Расписание"]));
                }
                if ((ds.Tables["Сетки"] != null)) {
                    base.Tables.Add(new СеткиDataTable(ds.Tables["Сетки"]));
                }
                if ((ds.Tables["Списки участников"] != null)) {
                    base.Tables.Add(new Списки_участниковDataTable(ds.Tables["Списки участников"]));
                }
                if ((ds.Tables["Справочник игроков"] != null)) {
                    base.Tables.Add(new Справочник_игроковDataTable(ds.Tables["Справочник игроков"]));
                }
                if ((ds.Tables["Справочник катерогий"] != null)) {
                    base.Tables.Add(new Справочник_катерогийDataTable(ds.Tables["Справочник катерогий"]));
                }
                if ((ds.Tables["Справочник кортов"] != null)) {
                    base.Tables.Add(new Справочник_кортовDataTable(ds.Tables["Справочник кортов"]));
                }
                if ((ds.Tables["Справочник систем проведения"] != null)) {
                    base.Tables.Add(new Справочник_систем_проведенияDataTable(ds.Tables["Справочник систем проведения"]));
                }
                if ((ds.Tables["Справочник этапов турнира"] != null)) {
                    base.Tables.Add(new Справочник_этапов_турнираDataTable(ds.Tables["Справочник этапов турнира"]));
                }
                if ((ds.Tables["Турниры"] != null)) {
                    base.Tables.Add(new ТурнирыDataTable(ds.Tables["Турниры"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public int Next_DB_index(string codename, string tablename)
        {
            System.Data.OleDb.OleDbCommand Command;
            Command = new global::System.Data.OleDb.OleDbCommand();
            System.Data.OleDb.OleDbConnection Connection;
            Connection = new global::System.Data.OleDb.OleDbConnection();

            Command.CommandText = "SELECT MAX ([" + codename + "]) FROM [" + tablename + "]";
            Command.Connection = Connection;
            Connection.ConnectionString = global::kp2_2.Properties.Settings.Default.kp2ConnectionString;
            Connection.Open();
            //int index = (int)Command.ExecuteScalar();
            int index = Command.ExecuteScalar() == System.DBNull.Value ? 0 : (int)Command.ExecuteScalar();
            Connection.Close();
            return index + 1;
        }
        public РасписаниеDataTable Расписание {
            get {
                return this.tableРасписание;
            }
        }        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public СеткиDataTable Сетки {
            get {
                return this.tableСетки;
            }
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public Списки_участниковDataTable Списки_участников {
            get {
                return this.tableСписки_участников;
            }
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public Справочник_игроковDataTable Справочник_игроков {
            get {
                return this.tableСправочник_игроков;
            }
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public Справочник_катерогийDataTable Справочник_катерогий {
            get {
                return this.tableСправочник_катерогий;
            }
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public Справочник_кортовDataTable Справочник_кортов {
            get {
                return this.tableСправочник_кортов;
            }
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public Справочник_систем_проведенияDataTable Справочник_систем_проведения {
            get {
                return this.tableСправочник_систем_проведения;
            }
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public Справочник_этапов_турнираDataTable Справочник_этапов_турнира {
            get {
                return this.tableСправочник_этапов_турнира;
            }
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public ТурнирыDataTable Турниры {
            get {
                return this.tableТурниры;
            }
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public override global::System.Data.DataSet Clone() {
            кп2_DataSet cln = ((кп2_DataSet)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["Расписание"] != null)) {
                    base.Tables.Add(new РасписаниеDataTable(ds.Tables["Расписание"]));
                }
                if ((ds.Tables["Сетки"] != null)) {
                    base.Tables.Add(new СеткиDataTable(ds.Tables["Сетки"]));
                }
                if ((ds.Tables["Списки участников"] != null)) {
                    base.Tables.Add(new Списки_участниковDataTable(ds.Tables["Списки участников"]));
                }
                if ((ds.Tables["Справочник игроков"] != null)) {
                    base.Tables.Add(new Справочник_игроковDataTable(ds.Tables["Справочник игроков"]));
                }
                if ((ds.Tables["Справочник катерогий"] != null)) {
                    base.Tables.Add(new Справочник_катерогийDataTable(ds.Tables["Справочник катерогий"]));
                }
                if ((ds.Tables["Справочник кортов"] != null)) {
                    base.Tables.Add(new Справочник_кортовDataTable(ds.Tables["Справочник кортов"]));
                }
                if ((ds.Tables["Справочник систем проведения"] != null)) {
                    base.Tables.Add(new Справочник_систем_проведенияDataTable(ds.Tables["Справочник систем проведения"]));
                }
                if ((ds.Tables["Справочник этапов турнира"] != null)) {
                    base.Tables.Add(new Справочник_этапов_турнираDataTable(ds.Tables["Справочник этапов турнира"]));
                }
                if ((ds.Tables["Турниры"] != null)) {
                    base.Tables.Add(new ТурнирыDataTable(ds.Tables["Турниры"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal void InitVars(bool initTable) {
            this.tableРасписание = ((РасписаниеDataTable)(base.Tables["Расписание"]));
            if ((initTable == true)) {
                if ((this.tableРасписание != null)) {
                    this.tableРасписание.InitVars();
                }
            }
            this.tableСетки = ((СеткиDataTable)(base.Tables["Сетки"]));
            if ((initTable == true)) {
                if ((this.tableСетки != null)) {
                    this.tableСетки.InitVars();
                }
            }
            this.tableСписки_участников = ((Списки_участниковDataTable)(base.Tables["Списки участников"]));
            if ((initTable == true)) {
                if ((this.tableСписки_участников != null)) {
                    this.tableСписки_участников.InitVars();
                }
            }
            this.tableСправочник_игроков = ((Справочник_игроковDataTable)(base.Tables["Справочник игроков"]));
            if ((initTable == true)) {
                if ((this.tableСправочник_игроков != null)) {
                    this.tableСправочник_игроков.InitVars();
                }
            }
            this.tableСправочник_катерогий = ((Справочник_катерогийDataTable)(base.Tables["Справочник катерогий"]));
            if ((initTable == true)) {
                if ((this.tableСправочник_катерогий != null)) {
                    this.tableСправочник_катерогий.InitVars();
                }
            }
            this.tableСправочник_кортов = ((Справочник_кортовDataTable)(base.Tables["Справочник кортов"]));
            if ((initTable == true)) {
                if ((this.tableСправочник_кортов != null)) {
                    this.tableСправочник_кортов.InitVars();
                }
            }
            this.tableСправочник_систем_проведения = ((Справочник_систем_проведенияDataTable)(base.Tables["Справочник систем проведения"]));
            if ((initTable == true)) {
                if ((this.tableСправочник_систем_проведения != null)) {
                    this.tableСправочник_систем_проведения.InitVars();
                }
            }
            this.tableСправочник_этапов_турнира = ((Справочник_этапов_турнираDataTable)(base.Tables["Справочник этапов турнира"]));
            if ((initTable == true)) {
                if ((this.tableСправочник_этапов_турнира != null)) {
                    this.tableСправочник_этапов_турнира.InitVars();
                }
            }
            this.tableТурниры = ((ТурнирыDataTable)(base.Tables["Турниры"]));
            if ((initTable == true)) {
                if ((this.tableТурниры != null)) {
                    this.tableТурниры.InitVars();
                }
            }
            this.relationСеткиРасписание = this.Relations["СеткиРасписание"];
            this.relationТурнирыРасписание = this.Relations["ТурнирыРасписание"];
            this.relationСправочник_этапов_турнираСетки = this.Relations["Справочник этапов турнираСетки"];
            this.relationТурнирыСетки = this.Relations["ТурнирыСетки"];
            this.relationСправочник_игроковСписки_участников = this.Relations["Справочник игроковСписки участников"];
            this.relationСправочник_игроковСписки_участников1 = this.Relations["Справочник игроковСписки участников1"];
            this.relationТурнирыСписки_участников = this.Relations["ТурнирыСписки участников"];
            this.relationСправочник_систем_проведенияСправочник_этапов_турнира = this.Relations["Справочник систем проведенияСправочник этапов турнира"];
            this.relationСправочник_катерогийТурниры = this.Relations["Справочник катерогийТурниры"];
            this.relationСправочник_кортовТурниры = this.Relations["Справочник кортовТурниры"];
            this.relationСправочник_кортовТурниры1 = this.Relations["Справочник кортовТурниры1"];
            this.relationСправочник_кортовТурниры2 = this.Relations["Справочник кортовТурниры2"];
            this.relationСправочник_систем_проведенияТурниры = this.Relations["Справочник систем проведенияТурниры"];
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitClass() {
            this.DataSetName = "кп2_DataSet";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/кп2_DataSet.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableРасписание = new РасписаниеDataTable();
            base.Tables.Add(this.tableРасписание);
            this.tableСетки = new СеткиDataTable();
            base.Tables.Add(this.tableСетки);
            this.tableСписки_участников = new Списки_участниковDataTable();
            base.Tables.Add(this.tableСписки_участников);
            this.tableСправочник_игроков = new Справочник_игроковDataTable();
            base.Tables.Add(this.tableСправочник_игроков);
            this.tableСправочник_катерогий = new Справочник_катерогийDataTable();
            base.Tables.Add(this.tableСправочник_катерогий);
            this.tableСправочник_кортов = new Справочник_кортовDataTable();
            base.Tables.Add(this.tableСправочник_кортов);
            this.tableСправочник_систем_проведения = new Справочник_систем_проведенияDataTable();
            base.Tables.Add(this.tableСправочник_систем_проведения);
            this.tableСправочник_этапов_турнира = new Справочник_этапов_турнираDataTable();
            base.Tables.Add(this.tableСправочник_этапов_турнира);
            this.tableТурниры = new ТурнирыDataTable();
            base.Tables.Add(this.tableТурниры);
            this.relationСеткиРасписание = new global::System.Data.DataRelation("СеткиРасписание", new global::System.Data.DataColumn[] {
                        this.tableСетки.Код_матчаColumn}, new global::System.Data.DataColumn[] {
                        this.tableРасписание.Код_матчаColumn}, false);
            this.Relations.Add(this.relationСеткиРасписание);
            this.relationТурнирыРасписание = new global::System.Data.DataRelation("ТурнирыРасписание", new global::System.Data.DataColumn[] {
                        this.tableТурниры.Код_турнираColumn}, new global::System.Data.DataColumn[] {
                        this.tableРасписание.Код_турнираColumn}, false);
            this.Relations.Add(this.relationТурнирыРасписание);
            this.relationСправочник_этапов_турнираСетки = new global::System.Data.DataRelation("Справочник этапов турнираСетки", new global::System.Data.DataColumn[] {
                        this.tableСправочник_этапов_турнира.Код_этапаColumn}, new global::System.Data.DataColumn[] {
                        this.tableСетки.ЭтапColumn}, false);
            this.Relations.Add(this.relationСправочник_этапов_турнираСетки);
            this.relationТурнирыСетки = new global::System.Data.DataRelation("ТурнирыСетки", new global::System.Data.DataColumn[] {
                        this.tableТурниры.Код_турнираColumn}, new global::System.Data.DataColumn[] {
                        this.tableСетки.Код_турнираColumn}, false);
            this.Relations.Add(this.relationТурнирыСетки);
            this.relationСправочник_игроковСписки_участников = new global::System.Data.DataRelation("Справочник игроковСписки участников", new global::System.Data.DataColumn[] {
                        this.tableСправочник_игроков.Код_игрокаColumn}, new global::System.Data.DataColumn[] {
                        this.tableСписки_участников.Код_игрока_1Column}, false);
            this.Relations.Add(this.relationСправочник_игроковСписки_участников);
            this.relationСправочник_игроковСписки_участников1 = new global::System.Data.DataRelation("Справочник игроковСписки участников1", new global::System.Data.DataColumn[] {
                        this.tableСправочник_игроков.Код_игрокаColumn}, new global::System.Data.DataColumn[] {
                        this.tableСписки_участников.Код_игрока_2Column}, false);
            this.Relations.Add(this.relationСправочник_игроковСписки_участников1);
            this.relationТурнирыСписки_участников = new global::System.Data.DataRelation("ТурнирыСписки участников", new global::System.Data.DataColumn[] {
                        this.tableТурниры.Код_турнираColumn}, new global::System.Data.DataColumn[] {
                        this.tableСписки_участников.Код_турнираColumn}, false);
            this.Relations.Add(this.relationТурнирыСписки_участников);
            this.relationСправочник_систем_проведенияСправочник_этапов_турнира = new global::System.Data.DataRelation("Справочник систем проведенияСправочник этапов турнира", new global::System.Data.DataColumn[] {
                        this.tableСправочник_систем_проведения.Код_системыColumn}, new global::System.Data.DataColumn[] {
                        this.tableСправочник_этапов_турнира.Код_системы_проведенияColumn}, false);
            this.Relations.Add(this.relationСправочник_систем_проведенияСправочник_этапов_турнира);
            this.relationСправочник_катерогийТурниры = new global::System.Data.DataRelation("Справочник катерогийТурниры", new global::System.Data.DataColumn[] {
                        this.tableСправочник_катерогий.Код_категорииColumn}, new global::System.Data.DataColumn[] {
                        this.tableТурниры.Код_категорииColumn}, false);
            this.Relations.Add(this.relationСправочник_катерогийТурниры);
            this.relationСправочник_кортовТурниры = new global::System.Data.DataRelation("Справочник кортовТурниры", new global::System.Data.DataColumn[] {
                        this.tableСправочник_кортов.Код_кортаColumn}, new global::System.Data.DataColumn[] {
                        this.tableТурниры.Код_корта_1Column}, false);
            this.Relations.Add(this.relationСправочник_кортовТурниры);
            this.relationСправочник_кортовТурниры1 = new global::System.Data.DataRelation("Справочник кортовТурниры1", new global::System.Data.DataColumn[] {
                        this.tableСправочник_кортов.Код_кортаColumn}, new global::System.Data.DataColumn[] {
                        this.tableТурниры.Код_корта_2Column}, false);
            this.Relations.Add(this.relationСправочник_кортовТурниры1);
            this.relationСправочник_кортовТурниры2 = new global::System.Data.DataRelation("Справочник кортовТурниры2", new global::System.Data.DataColumn[] {
                        this.tableСправочник_кортов.Код_кортаColumn}, new global::System.Data.DataColumn[] {
                        this.tableТурниры.Код_корта_3Column}, false);
            this.Relations.Add(this.relationСправочник_кортовТурниры2);
            this.relationСправочник_систем_проведенияТурниры = new global::System.Data.DataRelation("Справочник систем проведенияТурниры", new global::System.Data.DataColumn[] {
                        this.tableСправочник_систем_проведения.Код_системыColumn}, new global::System.Data.DataColumn[] {
                        this.tableТурниры.Код_системы_проведенияColumn}, false);
            this.Relations.Add(this.relationСправочник_систем_проведенияТурниры);
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private bool ShouldSerializeРасписание() {
            return false;
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private bool ShouldSerializeСетки() {
            return false;
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private bool ShouldSerializeСписки_участников() {
            return false;
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private bool ShouldSerializeСправочник_игроков() {
            return false;
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private bool ShouldSerializeСправочник_катерогий() {
            return false;
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private bool ShouldSerializeСправочник_кортов() {
            return false;
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private bool ShouldSerializeСправочник_систем_проведения() {
            return false;
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private bool ShouldSerializeСправочник_этапов_турнира() {
            return false;
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private bool ShouldSerializeТурниры() {
            return false;
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            кп2_DataSet ds = new кп2_DataSet();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public delegate void РасписаниеRowChangeEventHandler(object sender, РасписаниеRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public delegate void СеткиRowChangeEventHandler(object sender, СеткиRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public delegate void Списки_участниковRowChangeEventHandler(object sender, Списки_участниковRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public delegate void Справочник_игроковRowChangeEventHandler(object sender, Справочник_игроковRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public delegate void Справочник_катерогийRowChangeEventHandler(object sender, Справочник_катерогийRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public delegate void Справочник_кортовRowChangeEventHandler(object sender, Справочник_кортовRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public delegate void Справочник_систем_проведенияRowChangeEventHandler(object sender, Справочник_систем_проведенияRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public delegate void Справочник_этапов_турнираRowChangeEventHandler(object sender, Справочник_этапов_турнираRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public delegate void ТурнирыRowChangeEventHandler(object sender, ТурнирыRowChangeEvent e);
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class РасписаниеDataTable : global::System.Data.TypedTableBase<РасписаниеRow> {
            
            private global::System.Data.DataColumn columnКод_матча;
            
            private global::System.Data.DataColumn columnКод_турнира;
            
            private global::System.Data.DataColumn columnКорт;
            
            private global::System.Data.DataColumn columnВремя_начала;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public РасписаниеDataTable() {
                this.TableName = "Расписание";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal РасписаниеDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected РасписаниеDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_матчаColumn {
                get {
                    return this.columnКод_матча;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_турнираColumn {
                get {
                    return this.columnКод_турнира;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn КортColumn {
                get {
                    return this.columnКорт;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Время_началаColumn {
                get {
                    return this.columnВремя_начала;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public РасписаниеRow this[int index] {
                get {
                    return ((РасписаниеRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event РасписаниеRowChangeEventHandler РасписаниеRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event РасписаниеRowChangeEventHandler РасписаниеRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event РасписаниеRowChangeEventHandler РасписаниеRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event РасписаниеRowChangeEventHandler РасписаниеRowDeleted;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void AddРасписаниеRow(РасписаниеRow row) {
                this.Rows.Add(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public РасписаниеRow AddРасписаниеRow(ТурнирыRow parentТурнирыRowByТурнирыРасписание, int Корт, System.DateTime Время_начала) {
                РасписаниеRow rowРасписаниеRow = ((РасписаниеRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        null,
                        Корт,
                        Время_начала};
                if ((parentТурнирыRowByТурнирыРасписание != null)) {
                    columnValuesArray[1] = parentТурнирыRowByТурнирыРасписание[0];
                }
                rowРасписаниеRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowРасписаниеRow);
                return rowРасписаниеRow;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public РасписаниеRow FindByКод_матча(int Код_матча) {
                return ((РасписаниеRow)(this.Rows.Find(new object[] {
                            Код_матча})));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                РасписаниеDataTable cln = ((РасписаниеDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new РасписаниеDataTable();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal void InitVars() {
                this.columnКод_матча = base.Columns["Код матча"];
                this.columnКод_турнира = base.Columns["Код турнира"];
                this.columnКорт = base.Columns["Корт"];
                this.columnВремя_начала = base.Columns["Время начала"];
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private void InitClass() {
                this.columnКод_матча = new global::System.Data.DataColumn("Код матча", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_матча);
                this.columnКод_турнира = new global::System.Data.DataColumn("Код турнира", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_турнира);
                this.columnКорт = new global::System.Data.DataColumn("Корт", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКорт);
                this.columnВремя_начала = new global::System.Data.DataColumn("Время начала", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnВремя_начала);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnКод_матча}, true));
                this.columnКод_матча.AutoIncrement = true;
                this.columnКод_матча.AutoIncrementSeed = -1;
                this.columnКод_матча.AutoIncrementStep = -1;
                this.columnКод_матча.AllowDBNull = false;
                this.columnКод_матча.Unique = true;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public РасписаниеRow NewРасписаниеRow() {
                return ((РасписаниеRow)(this.NewRow()));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new РасписаниеRow(builder);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(РасписаниеRow);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.РасписаниеRowChanged != null)) {
                    this.РасписаниеRowChanged(this, new РасписаниеRowChangeEvent(((РасписаниеRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.РасписаниеRowChanging != null)) {
                    this.РасписаниеRowChanging(this, new РасписаниеRowChangeEvent(((РасписаниеRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.РасписаниеRowDeleted != null)) {
                    this.РасписаниеRowDeleted(this, new РасписаниеRowChangeEvent(((РасписаниеRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.РасписаниеRowDeleting != null)) {
                    this.РасписаниеRowDeleting(this, new РасписаниеRowChangeEvent(((РасписаниеRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void RemoveРасписаниеRow(РасписаниеRow row) {
                this.Rows.Remove(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                кп2_DataSet ds = new кп2_DataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "РасписаниеDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class СеткиDataTable : global::System.Data.TypedTableBase<СеткиRow> {
            
            private global::System.Data.DataColumn columnКод_матча;
            
            private global::System.Data.DataColumn columnКод_турнира;
            
            private global::System.Data.DataColumn columnКод_участника_1;
            
            private global::System.Data.DataColumn columnКод_участника_2;
            
            private global::System.Data.DataColumn columnСчёт_первого_сета;
            
            private global::System.Data.DataColumn columnСчёт_второго_сета;
            
            private global::System.Data.DataColumn columnСчёт_третьего_сета;
            
            private global::System.Data.DataColumn columnПобедитель;
            
            private global::System.Data.DataColumn columnЭтап;
            
            private global::System.Data.DataColumn columnМесто;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public СеткиDataTable() {
                this.TableName = "Сетки";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal СеткиDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected СеткиDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_матчаColumn {
                get {
                    return this.columnКод_матча;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_турнираColumn {
                get {
                    return this.columnКод_турнира;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_участника_1Column {
                get {
                    return this.columnКод_участника_1;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_участника_2Column {
                get {
                    return this.columnКод_участника_2;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Счёт_первого_сетаColumn {
                get {
                    return this.columnСчёт_первого_сета;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Счёт_второго_сетаColumn {
                get {
                    return this.columnСчёт_второго_сета;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Счёт_третьего_сетаColumn {
                get {
                    return this.columnСчёт_третьего_сета;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn ПобедительColumn {
                get {
                    return this.columnПобедитель;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn ЭтапColumn {
                get {
                    return this.columnЭтап;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn МестоColumn {
                get {
                    return this.columnМесто;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public СеткиRow this[int index] {
                get {
                    return ((СеткиRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event СеткиRowChangeEventHandler СеткиRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event СеткиRowChangeEventHandler СеткиRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event СеткиRowChangeEventHandler СеткиRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event СеткиRowChangeEventHandler СеткиRowDeleted;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void AddСеткиRow(СеткиRow row) {
                this.Rows.Add(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public СеткиRow AddСеткиRow(ТурнирыRow parentТурнирыRowByТурнирыСетки, int Код_участника_1, int Код_участника_2, string Счёт_первого_сета, string Счёт_второго_сета, string Счёт_третьего_сета, int Победитель, Справочник_этапов_турнираRow parentСправочник_этапов_турнираRowByСправочник_этапов_турнираСетки, int Место) {
                СеткиRow rowСеткиRow = ((СеткиRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        null,
                        Код_участника_1,
                        Код_участника_2,
                        Счёт_первого_сета,
                        Счёт_второго_сета,
                        Счёт_третьего_сета,
                        Победитель,
                        null,
                        Место};
                if ((parentТурнирыRowByТурнирыСетки != null)) {
                    columnValuesArray[1] = parentТурнирыRowByТурнирыСетки[0];
                }
                if ((parentСправочник_этапов_турнираRowByСправочник_этапов_турнираСетки != null)) {
                    columnValuesArray[8] = parentСправочник_этапов_турнираRowByСправочник_этапов_турнираСетки[0];
                }
                rowСеткиRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowСеткиRow);
                return rowСеткиRow;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public СеткиRow FindByКод_матча(int Код_матча) {
                return ((СеткиRow)(this.Rows.Find(new object[] {
                            Код_матча})));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                СеткиDataTable cln = ((СеткиDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new СеткиDataTable();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal void InitVars() {
                this.columnКод_матча = base.Columns["Код матча"];
                this.columnКод_турнира = base.Columns["Код турнира"];
                this.columnКод_участника_1 = base.Columns["Код участника 1"];
                this.columnКод_участника_2 = base.Columns["Код участника 2"];
                this.columnСчёт_первого_сета = base.Columns["Счёт первого сета"];
                this.columnСчёт_второго_сета = base.Columns["Счёт второго сета"];
                this.columnСчёт_третьего_сета = base.Columns["Счёт третьего сета"];
                this.columnПобедитель = base.Columns["Победитель"];
                this.columnЭтап = base.Columns["Этап"];
                this.columnМесто = base.Columns["Место"];
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private void InitClass() {
                this.columnКод_матча = new global::System.Data.DataColumn("Код матча", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_матча);
                this.columnКод_турнира = new global::System.Data.DataColumn("Код турнира", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_турнира);
                this.columnКод_участника_1 = new global::System.Data.DataColumn("Код участника 1", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_участника_1);
                this.columnКод_участника_2 = new global::System.Data.DataColumn("Код участника 2", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_участника_2);
                this.columnСчёт_первого_сета = new global::System.Data.DataColumn("Счёт первого сета", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnСчёт_первого_сета);
                this.columnСчёт_второго_сета = new global::System.Data.DataColumn("Счёт второго сета", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnСчёт_второго_сета);
                this.columnСчёт_третьего_сета = new global::System.Data.DataColumn("Счёт третьего сета", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnСчёт_третьего_сета);
                this.columnПобедитель = new global::System.Data.DataColumn("Победитель", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnПобедитель);
                this.columnЭтап = new global::System.Data.DataColumn("Этап", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnЭтап);
                this.columnМесто = new global::System.Data.DataColumn("Место", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnМесто);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnКод_матча}, true));
                this.columnКод_матча.AutoIncrement = true;
                this.columnКод_матча.AutoIncrementSeed = -1;
                this.columnКод_матча.AutoIncrementStep = -1;
                this.columnКод_матча.AllowDBNull = false;
                this.columnКод_матча.Unique = true;
                this.columnСчёт_первого_сета.MaxLength = 255;
                this.columnСчёт_второго_сета.MaxLength = 255;
                this.columnСчёт_третьего_сета.MaxLength = 255;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public СеткиRow NewСеткиRow() {
                return ((СеткиRow)(this.NewRow()));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new СеткиRow(builder);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(СеткиRow);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.СеткиRowChanged != null)) {
                    this.СеткиRowChanged(this, new СеткиRowChangeEvent(((СеткиRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.СеткиRowChanging != null)) {
                    this.СеткиRowChanging(this, new СеткиRowChangeEvent(((СеткиRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.СеткиRowDeleted != null)) {
                    this.СеткиRowDeleted(this, new СеткиRowChangeEvent(((СеткиRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.СеткиRowDeleting != null)) {
                    this.СеткиRowDeleting(this, new СеткиRowChangeEvent(((СеткиRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void RemoveСеткиRow(СеткиRow row) {
                this.Rows.Remove(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                кп2_DataSet ds = new кп2_DataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "СеткиDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class Списки_участниковDataTable : global::System.Data.TypedTableBase<Списки_участниковRow> {
            
            private global::System.Data.DataColumn columnКод_учаcтника;
            
            private global::System.Data.DataColumn columnКод_турнира;
            
            private global::System.Data.DataColumn columnКод_игрока_1;
            
            private global::System.Data.DataColumn columnКод_игрока_2;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Списки_участниковDataTable() {
                this.TableName = "Списки участников";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal Списки_участниковDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected Списки_участниковDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_учаcтникаColumn {
                get {
                    return this.columnКод_учаcтника;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_турнираColumn {
                get {
                    return this.columnКод_турнира;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_игрока_1Column {
                get {
                    return this.columnКод_игрока_1;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_игрока_2Column {
                get {
                    return this.columnКод_игрока_2;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Списки_участниковRow this[int index] {
                get {
                    return ((Списки_участниковRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Списки_участниковRowChangeEventHandler Списки_участниковRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Списки_участниковRowChangeEventHandler Списки_участниковRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Списки_участниковRowChangeEventHandler Списки_участниковRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Списки_участниковRowChangeEventHandler Списки_участниковRowDeleted;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void AddСписки_участниковRow(Списки_участниковRow row) {
                this.Rows.Add(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Списки_участниковRow AddСписки_участниковRow(ТурнирыRow parentТурнирыRowByТурнирыСписки_участников, Справочник_игроковRow parentСправочник_игроковRowByСправочник_игроковСписки_участников, Справочник_игроковRow parentСправочник_игроковRowByСправочник_игроковСписки_участников1) {
                Списки_участниковRow rowСписки_участниковRow = ((Списки_участниковRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        null,
                        null,
                        null};
                if ((parentТурнирыRowByТурнирыСписки_участников != null)) {
                    columnValuesArray[1] = parentТурнирыRowByТурнирыСписки_участников[0];
                }
                if ((parentСправочник_игроковRowByСправочник_игроковСписки_участников != null)) {
                    columnValuesArray[2] = parentСправочник_игроковRowByСправочник_игроковСписки_участников[0];
                }
                if ((parentСправочник_игроковRowByСправочник_игроковСписки_участников1 != null)) {
                    columnValuesArray[3] = parentСправочник_игроковRowByСправочник_игроковСписки_участников1[0];
                }
                rowСписки_участниковRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowСписки_участниковRow);
                return rowСписки_участниковRow;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Списки_участниковRow FindByКод_учаcтника(int Код_учаcтника) {
                return ((Списки_участниковRow)(this.Rows.Find(new object[] {
                            Код_учаcтника})));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                Списки_участниковDataTable cln = ((Списки_участниковDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new Списки_участниковDataTable();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal void InitVars() {
                this.columnКод_учаcтника = base.Columns["Код учаcтника"];
                this.columnКод_турнира = base.Columns["Код турнира"];
                this.columnКод_игрока_1 = base.Columns["Код игрока 1"];
                this.columnКод_игрока_2 = base.Columns["Код игрока 2"];
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private void InitClass() {
                this.columnКод_учаcтника = new global::System.Data.DataColumn("Код учаcтника", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_учаcтника);
                this.columnКод_турнира = new global::System.Data.DataColumn("Код турнира", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_турнира);
                this.columnКод_игрока_1 = new global::System.Data.DataColumn("Код игрока 1", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_игрока_1);
                this.columnКод_игрока_2 = new global::System.Data.DataColumn("Код игрока 2", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_игрока_2);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnКод_учаcтника}, true));
                this.columnКод_учаcтника.AutoIncrement = true;
                this.columnКод_учаcтника.AutoIncrementSeed = -1;
                this.columnКод_учаcтника.AutoIncrementStep = -1;
                this.columnКод_учаcтника.AllowDBNull = false;
                this.columnКод_учаcтника.Unique = true;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Списки_участниковRow NewСписки_участниковRow() {
                return ((Списки_участниковRow)(this.NewRow()));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new Списки_участниковRow(builder);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(Списки_участниковRow);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.Списки_участниковRowChanged != null)) {
                    this.Списки_участниковRowChanged(this, new Списки_участниковRowChangeEvent(((Списки_участниковRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.Списки_участниковRowChanging != null)) {
                    this.Списки_участниковRowChanging(this, new Списки_участниковRowChangeEvent(((Списки_участниковRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.Списки_участниковRowDeleted != null)) {
                    this.Списки_участниковRowDeleted(this, new Списки_участниковRowChangeEvent(((Списки_участниковRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.Списки_участниковRowDeleting != null)) {
                    this.Списки_участниковRowDeleting(this, new Списки_участниковRowChangeEvent(((Списки_участниковRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void RemoveСписки_участниковRow(Списки_участниковRow row) {
                this.Rows.Remove(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                кп2_DataSet ds = new кп2_DataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "Списки_участниковDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class Справочник_игроковDataTable : global::System.Data.TypedTableBase<Справочник_игроковRow> {
            
            private global::System.Data.DataColumn columnКод_игрока;
            
            private global::System.Data.DataColumn columnФамилия;
            
            private global::System.Data.DataColumn columnИмя;
            
            private global::System.Data.DataColumn columnОтчетсво;
            
            private global::System.Data.DataColumn columnДата_рождения;
            
            private global::System.Data.DataColumn columnГород;
            
            private global::System.Data.DataColumn columnМобильный_телефон;
            
            private global::System.Data.DataColumn columnРейтинг;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_игроковDataTable() {
                this.TableName = "Справочник игроков";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal Справочник_игроковDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected Справочник_игроковDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_игрокаColumn {
                get {
                    return this.columnКод_игрока;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn ФамилияColumn {
                get {
                    return this.columnФамилия;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn ИмяColumn {
                get {
                    return this.columnИмя;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn ОтчетсвоColumn {
                get {
                    return this.columnОтчетсво;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Дата_рожденияColumn {
                get {
                    return this.columnДата_рождения;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn ГородColumn {
                get {
                    return this.columnГород;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Мобильный_телефонColumn {
                get {
                    return this.columnМобильный_телефон;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn РейтингColumn {
                get {
                    return this.columnРейтинг;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_игроковRow this[int index] {
                get {
                    return ((Справочник_игроковRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_игроковRowChangeEventHandler Справочник_игроковRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_игроковRowChangeEventHandler Справочник_игроковRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_игроковRowChangeEventHandler Справочник_игроковRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_игроковRowChangeEventHandler Справочник_игроковRowDeleted;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void AddСправочник_игроковRow(Справочник_игроковRow row) {
                this.Rows.Add(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_игроковRow AddСправочник_игроковRow(string Фамилия, string Имя, string Отчетсво, System.DateTime Дата_рождения, string Город, string Мобильный_телефон, int Рейтинг) {
                Справочник_игроковRow rowСправочник_игроковRow = ((Справочник_игроковRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Фамилия,
                        Имя,
                        Отчетсво,
                        Дата_рождения,
                        Город,
                        Мобильный_телефон,
                        Рейтинг};
                rowСправочник_игроковRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowСправочник_игроковRow);
                return rowСправочник_игроковRow;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_игроковRow FindByКод_игрока(int Код_игрока) {
                return ((Справочник_игроковRow)(this.Rows.Find(new object[] {
                            Код_игрока})));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                Справочник_игроковDataTable cln = ((Справочник_игроковDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new Справочник_игроковDataTable();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal void InitVars() {
                this.columnКод_игрока = base.Columns["Код игрока"];
                this.columnФамилия = base.Columns["Фамилия"];
                this.columnИмя = base.Columns["Имя"];
                this.columnОтчетсво = base.Columns["Отчетсво"];
                this.columnДата_рождения = base.Columns["Дата рождения"];
                this.columnГород = base.Columns["Город"];
                this.columnМобильный_телефон = base.Columns["Мобильный телефон"];
                this.columnРейтинг = base.Columns["Рейтинг"];
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private void InitClass() {
                this.columnКод_игрока = new global::System.Data.DataColumn("Код игрока", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_игрока);
                this.columnФамилия = new global::System.Data.DataColumn("Фамилия", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnФамилия);
                this.columnИмя = new global::System.Data.DataColumn("Имя", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnИмя);
                this.columnОтчетсво = new global::System.Data.DataColumn("Отчетсво", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnОтчетсво);
                this.columnДата_рождения = new global::System.Data.DataColumn("Дата рождения", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnДата_рождения);
                this.columnГород = new global::System.Data.DataColumn("Город", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnГород);
                this.columnМобильный_телефон = new global::System.Data.DataColumn("Мобильный телефон", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnМобильный_телефон);
                this.columnРейтинг = new global::System.Data.DataColumn("Рейтинг", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnРейтинг);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnКод_игрока}, true));
                this.columnКод_игрока.AutoIncrement = true;
                this.columnКод_игрока.AutoIncrementSeed = -1;
                this.columnКод_игрока.AutoIncrementStep = -1;
                this.columnКод_игрока.AllowDBNull = false;
                this.columnКод_игрока.Unique = true;
                this.columnФамилия.MaxLength = 255;
                this.columnИмя.MaxLength = 50;
                this.columnОтчетсво.MaxLength = 255;
                this.columnГород.MaxLength = 255;
                this.columnМобильный_телефон.MaxLength = 255;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_игроковRow NewСправочник_игроковRow() {
                return ((Справочник_игроковRow)(this.NewRow()));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new Справочник_игроковRow(builder);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(Справочник_игроковRow);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.Справочник_игроковRowChanged != null)) {
                    this.Справочник_игроковRowChanged(this, new Справочник_игроковRowChangeEvent(((Справочник_игроковRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.Справочник_игроковRowChanging != null)) {
                    this.Справочник_игроковRowChanging(this, new Справочник_игроковRowChangeEvent(((Справочник_игроковRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.Справочник_игроковRowDeleted != null)) {
                    this.Справочник_игроковRowDeleted(this, new Справочник_игроковRowChangeEvent(((Справочник_игроковRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.Справочник_игроковRowDeleting != null)) {
                    this.Справочник_игроковRowDeleting(this, new Справочник_игроковRowChangeEvent(((Справочник_игроковRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void RemoveСправочник_игроковRow(Справочник_игроковRow row) {
                this.Rows.Remove(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                кп2_DataSet ds = new кп2_DataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "Справочник_игроковDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class Справочник_катерогийDataTable : global::System.Data.TypedTableBase<Справочник_катерогийRow> {
            
            private global::System.Data.DataColumn columnКод_категории;
            
            private global::System.Data.DataColumn columnНазвание_категории;
            
            private global::System.Data.DataColumn columnОписание_категории;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_катерогийDataTable() {
                this.TableName = "Справочник катерогий";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal Справочник_катерогийDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected Справочник_катерогийDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_категорииColumn {
                get {
                    return this.columnКод_категории;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Название_категорииColumn {
                get {
                    return this.columnНазвание_категории;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Описание_категорииColumn {
                get {
                    return this.columnОписание_категории;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_катерогийRow this[int index] {
                get {
                    return ((Справочник_катерогийRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_катерогийRowChangeEventHandler Справочник_катерогийRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_катерогийRowChangeEventHandler Справочник_катерогийRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_катерогийRowChangeEventHandler Справочник_катерогийRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_катерогийRowChangeEventHandler Справочник_катерогийRowDeleted;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void AddСправочник_катерогийRow(Справочник_катерогийRow row) {
                this.Rows.Add(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_катерогийRow AddСправочник_катерогийRow(string Название_категории, string Описание_категории) {
                Справочник_катерогийRow rowСправочник_катерогийRow = ((Справочник_катерогийRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Название_категории,
                        Описание_категории};
                rowСправочник_катерогийRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowСправочник_катерогийRow);
                return rowСправочник_катерогийRow;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_катерогийRow FindByКод_категории(int Код_категории) {
                return ((Справочник_катерогийRow)(this.Rows.Find(new object[] {
                            Код_категории})));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                Справочник_катерогийDataTable cln = ((Справочник_катерогийDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new Справочник_катерогийDataTable();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal void InitVars() {
                this.columnКод_категории = base.Columns["Код категории"];
                this.columnНазвание_категории = base.Columns["Название категории"];
                this.columnОписание_категории = base.Columns["Описание категории"];
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private void InitClass() {
                this.columnКод_категории = new global::System.Data.DataColumn("Код категории", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_категории);
                this.columnНазвание_категории = new global::System.Data.DataColumn("Название категории", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnНазвание_категории);
                this.columnОписание_категории = new global::System.Data.DataColumn("Описание категории", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnОписание_категории);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnКод_категории}, true));
                this.columnКод_категории.AutoIncrement = true;
                this.columnКод_категории.AutoIncrementSeed = -1;
                this.columnКод_категории.AutoIncrementStep = -1;
                this.columnКод_категории.AllowDBNull = false;
                this.columnКод_категории.Unique = true;
                this.columnНазвание_категории.MaxLength = 255;
                this.columnОписание_категории.MaxLength = 536870910;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_катерогийRow NewСправочник_катерогийRow() {
                return ((Справочник_катерогийRow)(this.NewRow()));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new Справочник_катерогийRow(builder);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(Справочник_катерогийRow);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.Справочник_катерогийRowChanged != null)) {
                    this.Справочник_катерогийRowChanged(this, new Справочник_катерогийRowChangeEvent(((Справочник_катерогийRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.Справочник_катерогийRowChanging != null)) {
                    this.Справочник_катерогийRowChanging(this, new Справочник_катерогийRowChangeEvent(((Справочник_катерогийRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.Справочник_катерогийRowDeleted != null)) {
                    this.Справочник_катерогийRowDeleted(this, new Справочник_катерогийRowChangeEvent(((Справочник_катерогийRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.Справочник_катерогийRowDeleting != null)) {
                    this.Справочник_катерогийRowDeleting(this, new Справочник_катерогийRowChangeEvent(((Справочник_катерогийRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void RemoveСправочник_катерогийRow(Справочник_катерогийRow row) {
                this.Rows.Remove(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                кп2_DataSet ds = new кп2_DataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "Справочник_катерогийDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class Справочник_кортовDataTable : global::System.Data.TypedTableBase<Справочник_кортовRow> {
            
            private global::System.Data.DataColumn columnКод_корта;
            
            private global::System.Data.DataColumn columnНазвание_корта;
            
            private global::System.Data.DataColumn columnРасположение_корта;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_кортовDataTable() {
                this.TableName = "Справочник кортов";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal Справочник_кортовDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected Справочник_кортовDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_кортаColumn {
                get {
                    return this.columnКод_корта;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Название_кортаColumn {
                get {
                    return this.columnНазвание_корта;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Расположение_кортаColumn {
                get {
                    return this.columnРасположение_корта;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_кортовRow this[int index] {
                get {
                    return ((Справочник_кортовRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_кортовRowChangeEventHandler Справочник_кортовRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_кортовRowChangeEventHandler Справочник_кортовRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_кортовRowChangeEventHandler Справочник_кортовRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_кортовRowChangeEventHandler Справочник_кортовRowDeleted;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void AddСправочник_кортовRow(Справочник_кортовRow row) {
                this.Rows.Add(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_кортовRow AddСправочник_кортовRow(string Название_корта, string Расположение_корта) {
                Справочник_кортовRow rowСправочник_кортовRow = ((Справочник_кортовRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Название_корта,
                        Расположение_корта};
                rowСправочник_кортовRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowСправочник_кортовRow);
                return rowСправочник_кортовRow;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_кортовRow FindByКод_корта(int Код_корта) {
                return ((Справочник_кортовRow)(this.Rows.Find(new object[] {
                            Код_корта})));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                Справочник_кортовDataTable cln = ((Справочник_кортовDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new Справочник_кортовDataTable();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal void InitVars() {
                this.columnКод_корта = base.Columns["Код корта"];
                this.columnНазвание_корта = base.Columns["Название корта"];
                this.columnРасположение_корта = base.Columns["Расположение корта"];
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private void InitClass() {
                this.columnКод_корта = new global::System.Data.DataColumn("Код корта", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_корта);
                this.columnНазвание_корта = new global::System.Data.DataColumn("Название корта", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnНазвание_корта);
                this.columnРасположение_корта = new global::System.Data.DataColumn("Расположение корта", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnРасположение_корта);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnКод_корта}, true));
                this.columnКод_корта.AutoIncrement = true;
                this.columnКод_корта.AutoIncrementSeed = -1;
                this.columnКод_корта.AutoIncrementStep = -1;
                this.columnКод_корта.AllowDBNull = false;
                this.columnКод_корта.Unique = true;
                this.columnНазвание_корта.MaxLength = 255;
                this.columnРасположение_корта.MaxLength = 536870910;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_кортовRow NewСправочник_кортовRow() {
                return ((Справочник_кортовRow)(this.NewRow()));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new Справочник_кортовRow(builder);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(Справочник_кортовRow);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.Справочник_кортовRowChanged != null)) {
                    this.Справочник_кортовRowChanged(this, new Справочник_кортовRowChangeEvent(((Справочник_кортовRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.Справочник_кортовRowChanging != null)) {
                    this.Справочник_кортовRowChanging(this, new Справочник_кортовRowChangeEvent(((Справочник_кортовRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.Справочник_кортовRowDeleted != null)) {
                    this.Справочник_кортовRowDeleted(this, new Справочник_кортовRowChangeEvent(((Справочник_кортовRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.Справочник_кортовRowDeleting != null)) {
                    this.Справочник_кортовRowDeleting(this, new Справочник_кортовRowChangeEvent(((Справочник_кортовRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void RemoveСправочник_кортовRow(Справочник_кортовRow row) {
                this.Rows.Remove(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                кп2_DataSet ds = new кп2_DataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "Справочник_кортовDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class Справочник_систем_проведенияDataTable : global::System.Data.TypedTableBase<Справочник_систем_проведенияRow> {
            
            private global::System.Data.DataColumn columnКод_системы;
            
            private global::System.Data.DataColumn columnНазвание_системы;
            
            private global::System.Data.DataColumn columnОписание_системы;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_систем_проведенияDataTable() {
                this.TableName = "Справочник систем проведения";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal Справочник_систем_проведенияDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected Справочник_систем_проведенияDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_системыColumn {
                get {
                    return this.columnКод_системы;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Название_системыColumn {
                get {
                    return this.columnНазвание_системы;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Описание_системыColumn {
                get {
                    return this.columnОписание_системы;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_систем_проведенияRow this[int index] {
                get {
                    return ((Справочник_систем_проведенияRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_систем_проведенияRowChangeEventHandler Справочник_систем_проведенияRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_систем_проведенияRowChangeEventHandler Справочник_систем_проведенияRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_систем_проведенияRowChangeEventHandler Справочник_систем_проведенияRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_систем_проведенияRowChangeEventHandler Справочник_систем_проведенияRowDeleted;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void AddСправочник_систем_проведенияRow(Справочник_систем_проведенияRow row) {
                this.Rows.Add(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_систем_проведенияRow AddСправочник_систем_проведенияRow(string Название_системы, string Описание_системы) {
                Справочник_систем_проведенияRow rowСправочник_систем_проведенияRow = ((Справочник_систем_проведенияRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Название_системы,
                        Описание_системы};
                rowСправочник_систем_проведенияRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowСправочник_систем_проведенияRow);
                return rowСправочник_систем_проведенияRow;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_систем_проведенияRow FindByКод_системы(int Код_системы) {
                return ((Справочник_систем_проведенияRow)(this.Rows.Find(new object[] {
                            Код_системы})));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                Справочник_систем_проведенияDataTable cln = ((Справочник_систем_проведенияDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new Справочник_систем_проведенияDataTable();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal void InitVars() {
                this.columnКод_системы = base.Columns["Код системы"];
                this.columnНазвание_системы = base.Columns["Название системы"];
                this.columnОписание_системы = base.Columns["Описание системы"];
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private void InitClass() {
                this.columnКод_системы = new global::System.Data.DataColumn("Код системы", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_системы);
                this.columnНазвание_системы = new global::System.Data.DataColumn("Название системы", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnНазвание_системы);
                this.columnОписание_системы = new global::System.Data.DataColumn("Описание системы", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnОписание_системы);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnКод_системы}, true));
                this.columnКод_системы.AutoIncrement = true;
                this.columnКод_системы.AutoIncrementSeed = -1;
                this.columnКод_системы.AutoIncrementStep = -1;
                this.columnКод_системы.AllowDBNull = false;
                this.columnКод_системы.Unique = true;
                this.columnНазвание_системы.MaxLength = 255;
                this.columnОписание_системы.MaxLength = 536870910;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_систем_проведенияRow NewСправочник_систем_проведенияRow() {
                return ((Справочник_систем_проведенияRow)(this.NewRow()));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new Справочник_систем_проведенияRow(builder);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(Справочник_систем_проведенияRow);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.Справочник_систем_проведенияRowChanged != null)) {
                    this.Справочник_систем_проведенияRowChanged(this, new Справочник_систем_проведенияRowChangeEvent(((Справочник_систем_проведенияRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.Справочник_систем_проведенияRowChanging != null)) {
                    this.Справочник_систем_проведенияRowChanging(this, new Справочник_систем_проведенияRowChangeEvent(((Справочник_систем_проведенияRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.Справочник_систем_проведенияRowDeleted != null)) {
                    this.Справочник_систем_проведенияRowDeleted(this, new Справочник_систем_проведенияRowChangeEvent(((Справочник_систем_проведенияRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.Справочник_систем_проведенияRowDeleting != null)) {
                    this.Справочник_систем_проведенияRowDeleting(this, new Справочник_систем_проведенияRowChangeEvent(((Справочник_систем_проведенияRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void RemoveСправочник_систем_проведенияRow(Справочник_систем_проведенияRow row) {
                this.Rows.Remove(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                кп2_DataSet ds = new кп2_DataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "Справочник_систем_проведенияDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class Справочник_этапов_турнираDataTable : global::System.Data.TypedTableBase<Справочник_этапов_турнираRow> {
            
            private global::System.Data.DataColumn columnКод_этапа;
            
            private global::System.Data.DataColumn columnЭтап;
            
            private global::System.Data.DataColumn columnКод_системы_проведения;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_этапов_турнираDataTable() {
                this.TableName = "Справочник этапов турнира";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal Справочник_этапов_турнираDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected Справочник_этапов_турнираDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_этапаColumn {
                get {
                    return this.columnКод_этапа;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn ЭтапColumn {
                get {
                    return this.columnЭтап;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_системы_проведенияColumn {
                get {
                    return this.columnКод_системы_проведения;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_этапов_турнираRow this[int index] {
                get {
                    return ((Справочник_этапов_турнираRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_этапов_турнираRowChangeEventHandler Справочник_этапов_турнираRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_этапов_турнираRowChangeEventHandler Справочник_этапов_турнираRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_этапов_турнираRowChangeEventHandler Справочник_этапов_турнираRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event Справочник_этапов_турнираRowChangeEventHandler Справочник_этапов_турнираRowDeleted;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void AddСправочник_этапов_турнираRow(Справочник_этапов_турнираRow row) {
                this.Rows.Add(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_этапов_турнираRow AddСправочник_этапов_турнираRow(string Этап, Справочник_систем_проведенияRow parentСправочник_систем_проведенияRowByСправочник_систем_проведенияСправочник_этапов_турнира) {
                Справочник_этапов_турнираRow rowСправочник_этапов_турнираRow = ((Справочник_этапов_турнираRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Этап,
                        null};
                if ((parentСправочник_систем_проведенияRowByСправочник_систем_проведенияСправочник_этапов_турнира != null)) {
                    columnValuesArray[2] = parentСправочник_систем_проведенияRowByСправочник_систем_проведенияСправочник_этапов_турнира[0];
                }
                rowСправочник_этапов_турнираRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowСправочник_этапов_турнираRow);
                return rowСправочник_этапов_турнираRow;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_этапов_турнираRow FindByКод_этапа(int Код_этапа) {
                return ((Справочник_этапов_турнираRow)(this.Rows.Find(new object[] {
                            Код_этапа})));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                Справочник_этапов_турнираDataTable cln = ((Справочник_этапов_турнираDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new Справочник_этапов_турнираDataTable();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal void InitVars() {
                this.columnКод_этапа = base.Columns["Код этапа"];
                this.columnЭтап = base.Columns["Этап"];
                this.columnКод_системы_проведения = base.Columns["Код системы проведения"];
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private void InitClass() {
                this.columnКод_этапа = new global::System.Data.DataColumn("Код этапа", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_этапа);
                this.columnЭтап = new global::System.Data.DataColumn("Этап", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnЭтап);
                this.columnКод_системы_проведения = new global::System.Data.DataColumn("Код системы проведения", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_системы_проведения);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnКод_этапа}, true));
                this.columnКод_этапа.AutoIncrement = true;
                this.columnКод_этапа.AutoIncrementSeed = -1;
                this.columnКод_этапа.AutoIncrementStep = -1;
                this.columnКод_этапа.AllowDBNull = false;
                this.columnКод_этапа.Unique = true;
                this.columnЭтап.MaxLength = 255;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_этапов_турнираRow NewСправочник_этапов_турнираRow() {
                return ((Справочник_этапов_турнираRow)(this.NewRow()));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new Справочник_этапов_турнираRow(builder);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(Справочник_этапов_турнираRow);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.Справочник_этапов_турнираRowChanged != null)) {
                    this.Справочник_этапов_турнираRowChanged(this, new Справочник_этапов_турнираRowChangeEvent(((Справочник_этапов_турнираRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.Справочник_этапов_турнираRowChanging != null)) {
                    this.Справочник_этапов_турнираRowChanging(this, new Справочник_этапов_турнираRowChangeEvent(((Справочник_этапов_турнираRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.Справочник_этапов_турнираRowDeleted != null)) {
                    this.Справочник_этапов_турнираRowDeleted(this, new Справочник_этапов_турнираRowChangeEvent(((Справочник_этапов_турнираRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.Справочник_этапов_турнираRowDeleting != null)) {
                    this.Справочник_этапов_турнираRowDeleting(this, new Справочник_этапов_турнираRowChangeEvent(((Справочник_этапов_турнираRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void RemoveСправочник_этапов_турнираRow(Справочник_этапов_турнираRow row) {
                this.Rows.Remove(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                кп2_DataSet ds = new кп2_DataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "Справочник_этапов_турнираDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class ТурнирыDataTable : global::System.Data.TypedTableBase<ТурнирыRow> {
            
            private global::System.Data.DataColumn columnКод_турнира;
            
            private global::System.Data.DataColumn columnНаименование;
            
            private global::System.Data.DataColumn columnКод_категории;
            
            private global::System.Data.DataColumn columnКод_системы_проведения;
            
            private global::System.Data.DataColumn columnКоличество_участников;
            
            private global::System.Data.DataColumn columnРазряд;
            
            private global::System.Data.DataColumn columnКоличество_групп;
            
            private global::System.Data.DataColumn columnДата_начала;
            
            private global::System.Data.DataColumn columnДата_конца;
            
            private global::System.Data.DataColumn columnКоличество_кортов;
            
            private global::System.Data.DataColumn columnКод_корта_1;
            
            private global::System.Data.DataColumn columnКод_корта_2;
            
            private global::System.Data.DataColumn columnКод_корта_3;
            
            private global::System.Data.DataColumn columnВремя_начала_проведения;
            
            private global::System.Data.DataColumn columnВремя_конца_проведения;
            
            private global::System.Data.DataColumn columnДлительность_матча;
            
            private global::System.Data.DataColumn columnФИО_директора;
            
            private global::System.Data.DataColumn columnТелефон_директора;
            
            private global::System.Data.DataColumn columnКоличество_сеянных_участников;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public ТурнирыDataTable() {
                this.TableName = "Турниры";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal ТурнирыDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected ТурнирыDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_турнираColumn {
                get {
                    return this.columnКод_турнира;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn НаименованиеColumn {
                get {
                    return this.columnНаименование;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_категорииColumn {
                get {
                    return this.columnКод_категории;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_системы_проведенияColumn {
                get {
                    return this.columnКод_системы_проведения;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Количество_участниковColumn {
                get {
                    return this.columnКоличество_участников;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn РазрядColumn {
                get {
                    return this.columnРазряд;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Количество_группColumn {
                get {
                    return this.columnКоличество_групп;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Дата_началаColumn {
                get {
                    return this.columnДата_начала;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Дата_концаColumn {
                get {
                    return this.columnДата_конца;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Количество_кортовColumn {
                get {
                    return this.columnКоличество_кортов;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_корта_1Column {
                get {
                    return this.columnКод_корта_1;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_корта_2Column {
                get {
                    return this.columnКод_корта_2;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Код_корта_3Column {
                get {
                    return this.columnКод_корта_3;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Время_начала_проведенияColumn {
                get {
                    return this.columnВремя_начала_проведения;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Время_конца_проведенияColumn {
                get {
                    return this.columnВремя_конца_проведения;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Длительность_матчаColumn {
                get {
                    return this.columnДлительность_матча;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn ФИО_директораColumn {
                get {
                    return this.columnФИО_директора;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Телефон_директораColumn {
                get {
                    return this.columnТелефон_директора;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataColumn Количество_сеянных_участниковColumn {
                get {
                    return this.columnКоличество_сеянных_участников;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public ТурнирыRow this[int index] {
                get {
                    return ((ТурнирыRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event ТурнирыRowChangeEventHandler ТурнирыRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event ТурнирыRowChangeEventHandler ТурнирыRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event ТурнирыRowChangeEventHandler ТурнирыRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event ТурнирыRowChangeEventHandler ТурнирыRowDeleted;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void AddТурнирыRow(ТурнирыRow row) {
                this.Rows.Add(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public ТурнирыRow AddТурнирыRow(
                        string Наименование, 
                        Справочник_катерогийRow parentСправочник_катерогийRowByСправочник_катерогийТурниры, 
                        Справочник_систем_проведенияRow parentСправочник_систем_проведенияRowByСправочник_систем_проведенияТурниры, 
                        int Количество_участников, 
                        string Разряд, 
                        int Количество_групп, 
                        string Дата_начала, 
                        System.DateTime Дата_конца, 
                        int Количество_кортов, 
                        Справочник_кортовRow parentСправочник_кортовRowByСправочник_кортовТурниры, 
                        Справочник_кортовRow parentСправочник_кортовRowByСправочник_кортовТурниры1, 
                        Справочник_кортовRow parentСправочник_кортовRowByСправочник_кортовТурниры2, 
                        System.DateTime Время_начала_проведения, 
                        System.DateTime Время_конца_проведения, 
                        int Длительность_матча, 
                        string ФИО_директора, 
                        string Телефон_директора, 
                        int Количество_сеянных_участников) {
                ТурнирыRow rowТурнирыRow = ((ТурнирыRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Наименование,
                        null,
                        null,
                        Количество_участников,
                        Разряд,
                        Количество_групп,
                        Дата_начала,
                        Дата_конца,
                        Количество_кортов,
                        null,
                        null,
                        null,
                        Время_начала_проведения,
                        Время_конца_проведения,
                        Длительность_матча,
                        ФИО_директора,
                        Телефон_директора,
                        Количество_сеянных_участников};
                if ((parentСправочник_катерогийRowByСправочник_катерогийТурниры != null)) {
                    columnValuesArray[2] = parentСправочник_катерогийRowByСправочник_катерогийТурниры[0];
                }
                if ((parentСправочник_систем_проведенияRowByСправочник_систем_проведенияТурниры != null)) {
                    columnValuesArray[3] = parentСправочник_систем_проведенияRowByСправочник_систем_проведенияТурниры[0];
                }
                if ((parentСправочник_кортовRowByСправочник_кортовТурниры != null)) {
                    columnValuesArray[10] = parentСправочник_кортовRowByСправочник_кортовТурниры[0];
                }
                if ((parentСправочник_кортовRowByСправочник_кортовТурниры1 != null)) {
                    columnValuesArray[11] = parentСправочник_кортовRowByСправочник_кортовТурниры1[0];
                }
                if ((parentСправочник_кортовRowByСправочник_кортовТурниры2 != null)) {
                    columnValuesArray[12] = parentСправочник_кортовRowByСправочник_кортовТурниры2[0];
                }
                rowТурнирыRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowТурнирыRow);
                return rowТурнирыRow;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public ТурнирыRow FindByКод_турнира(int Код_турнира) {
                return ((ТурнирыRow)(this.Rows.Find(new object[] {
                            Код_турнира})));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                ТурнирыDataTable cln = ((ТурнирыDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new ТурнирыDataTable();
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal void InitVars() {
                this.columnКод_турнира = base.Columns["Код турнира"];
                this.columnНаименование = base.Columns["Наименование"];
                this.columnКод_категории = base.Columns["Код категории"];
                this.columnКод_системы_проведения = base.Columns["Код системы проведения"];
                this.columnКоличество_участников = base.Columns["Количество участников"];
                this.columnРазряд = base.Columns["Разряд"];
                this.columnКоличество_групп = base.Columns["Количество групп"];
                this.columnДата_начала = base.Columns["Дата начала"];
                this.columnДата_конца = base.Columns["Дата конца"];
                this.columnКоличество_кортов = base.Columns["Количество кортов"];
                this.columnКод_корта_1 = base.Columns["Код корта 1"];
                this.columnКод_корта_2 = base.Columns["Код корта 2"];
                this.columnКод_корта_3 = base.Columns["Код корта 3"];
                this.columnВремя_начала_проведения = base.Columns["Время начала проведения"];
                this.columnВремя_конца_проведения = base.Columns["Время конца проведения"];
                this.columnДлительность_матча = base.Columns["Длительность матча"];
                this.columnФИО_директора = base.Columns["ФИО директора"];
                this.columnТелефон_директора = base.Columns["Телефон директора"];
                this.columnКоличество_сеянных_участников = base.Columns["Количество сеянных участников"];
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private void InitClass() {
                this.columnКод_турнира = new global::System.Data.DataColumn("Код турнира", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_турнира);
                this.columnНаименование = new global::System.Data.DataColumn("Наименование", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnНаименование);
                this.columnКод_категории = new global::System.Data.DataColumn("Код категории", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_категории);
                this.columnКод_системы_проведения = new global::System.Data.DataColumn("Код системы проведения", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_системы_проведения);
                this.columnКоличество_участников = new global::System.Data.DataColumn("Количество участников", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКоличество_участников);
                this.columnРазряд = new global::System.Data.DataColumn("Разряд", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnРазряд);
                this.columnКоличество_групп = new global::System.Data.DataColumn("Количество групп", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКоличество_групп);
                this.columnДата_начала = new global::System.Data.DataColumn("Дата начала", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnДата_начала);
                this.columnДата_конца = new global::System.Data.DataColumn("Дата конца", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnДата_конца);
                this.columnКоличество_кортов = new global::System.Data.DataColumn("Количество кортов", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКоличество_кортов);
                this.columnКод_корта_1 = new global::System.Data.DataColumn("Код корта 1", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_корта_1);
                this.columnКод_корта_2 = new global::System.Data.DataColumn("Код корта 2", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_корта_2);
                this.columnКод_корта_3 = new global::System.Data.DataColumn("Код корта 3", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод_корта_3);
                this.columnВремя_начала_проведения = new global::System.Data.DataColumn("Время начала проведения", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnВремя_начала_проведения);
                this.columnВремя_конца_проведения = new global::System.Data.DataColumn("Время конца проведения", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnВремя_конца_проведения);
                this.columnДлительность_матча = new global::System.Data.DataColumn("Длительность матча", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnДлительность_матча);
                this.columnФИО_директора = new global::System.Data.DataColumn("ФИО директора", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnФИО_директора);
                this.columnТелефон_директора = new global::System.Data.DataColumn("Телефон директора", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnТелефон_директора);
                this.columnКоличество_сеянных_участников = new global::System.Data.DataColumn("Количество сеянных участников", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКоличество_сеянных_участников);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnКод_турнира}, true));
                this.columnКод_турнира.AutoIncrement = true;
                this.columnКод_турнира.AutoIncrementSeed = -1;
                this.columnКод_турнира.AutoIncrementStep = -1;
                this.columnКод_турнира.AllowDBNull = false;
                this.columnКод_турнира.Unique = true;
                this.columnНаименование.MaxLength = 255;
                this.columnРазряд.MaxLength = 255;
                this.columnДата_начала.MaxLength = 255;
                this.columnФИО_директора.MaxLength = 255;
                this.columnТелефон_директора.MaxLength = 255;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public ТурнирыRow NewТурнирыRow() {
                return ((ТурнирыRow)(this.NewRow()));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new ТурнирыRow(builder);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(ТурнирыRow);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.ТурнирыRowChanged != null)) {
                    this.ТурнирыRowChanged(this, new ТурнирыRowChangeEvent(((ТурнирыRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.ТурнирыRowChanging != null)) {
                    this.ТурнирыRowChanging(this, new ТурнирыRowChangeEvent(((ТурнирыRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.ТурнирыRowDeleted != null)) {
                    this.ТурнирыRowDeleted(this, new ТурнирыRowChangeEvent(((ТурнирыRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.ТурнирыRowDeleting != null)) {
                    this.ТурнирыRowDeleting(this, new ТурнирыRowChangeEvent(((ТурнирыRow)(e.Row)), e.Action));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void RemoveТурнирыRow(ТурнирыRow row) {
                this.Rows.Remove(row);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                кп2_DataSet ds = new кп2_DataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "ТурнирыDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class РасписаниеRow : global::System.Data.DataRow {
            
            private РасписаниеDataTable tableРасписание;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal РасписаниеRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableРасписание = ((РасписаниеDataTable)(this.Table));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_матча {
                get {
                    return ((int)(this[this.tableРасписание.Код_матчаColumn]));
                }
                set {
                    this[this.tableРасписание.Код_матчаColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_турнира {
                get {
                    try {
                        return ((int)(this[this.tableРасписание.Код_турнираColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Код турнира\' в таблице \'Расписание\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableРасписание.Код_турнираColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Корт {
                get {
                    try {
                        return ((int)(this[this.tableРасписание.КортColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Корт\' в таблице \'Расписание\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableРасписание.КортColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public System.DateTime Время_начала {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableРасписание.Время_началаColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Время начала\' в таблице \'Расписание\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableРасписание.Время_началаColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public СеткиRow СеткиRow {
                get {
                    return ((СеткиRow)(this.GetParentRow(this.Table.ParentRelations["СеткиРасписание"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["СеткиРасписание"]);
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public ТурнирыRow ТурнирыRow {
                get {
                    return ((ТурнирыRow)(this.GetParentRow(this.Table.ParentRelations["ТурнирыРасписание"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["ТурнирыРасписание"]);
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКод_турнираNull() {
                return this.IsNull(this.tableРасписание.Код_турнираColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКод_турнираNull() {
                this[this.tableРасписание.Код_турнираColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКортNull() {
                return this.IsNull(this.tableРасписание.КортColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКортNull() {
                this[this.tableРасписание.КортColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsВремя_началаNull() {
                return this.IsNull(this.tableРасписание.Время_началаColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetВремя_началаNull() {
                this[this.tableРасписание.Время_началаColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class СеткиRow : global::System.Data.DataRow {
            
            private СеткиDataTable tableСетки;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal СеткиRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableСетки = ((СеткиDataTable)(this.Table));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_матча {
                get {
                    return ((int)(this[this.tableСетки.Код_матчаColumn]));
                }
                set {
                    this[this.tableСетки.Код_матчаColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_турнира {
                get {
                    try {
                        return ((int)(this[this.tableСетки.Код_турнираColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Код турнира\' в таблице \'Сетки\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСетки.Код_турнираColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_участника_1 {
                get {
                    try {
                        return ((int)(this[this.tableСетки.Код_участника_1Column]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Код участника 1\' в таблице \'Сетки\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСетки.Код_участника_1Column] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_участника_2 {
                get {
                    try {
                        return ((int)(this[this.tableСетки.Код_участника_2Column]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Код участника 2\' в таблице \'Сетки\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСетки.Код_участника_2Column] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Счёт_первого_сета {
                get {
                    try {
                        return ((string)(this[this.tableСетки.Счёт_первого_сетаColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Счёт первого сета\' в таблице \'Сетки\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСетки.Счёт_первого_сетаColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Счёт_второго_сета {
                get {
                    try {
                        return ((string)(this[this.tableСетки.Счёт_второго_сетаColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Счёт второго сета\' в таблице \'Сетки\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСетки.Счёт_второго_сетаColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Счёт_третьего_сета {
                get {
                    try {
                        return ((string)(this[this.tableСетки.Счёт_третьего_сетаColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Счёт третьего сета\' в таблице \'Сетки\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСетки.Счёт_третьего_сетаColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Победитель {
                get {
                    try {
                        return ((int)(this[this.tableСетки.ПобедительColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Победитель\' в таблице \'Сетки\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСетки.ПобедительColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Этап {
                get {
                    try {
                        return ((int)(this[this.tableСетки.ЭтапColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Этап\' в таблице \'Сетки\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСетки.ЭтапColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Место {
                get {
                    try {
                        return ((int)(this[this.tableСетки.МестоColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Место\' в таблице \'Сетки\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСетки.МестоColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_этапов_турнираRow Справочник_этапов_турнираRow {
                get {
                    return ((Справочник_этапов_турнираRow)(this.GetParentRow(this.Table.ParentRelations["Справочник этапов турнираСетки"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Справочник этапов турнираСетки"]);
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public ТурнирыRow ТурнирыRow {
                get {
                    return ((ТурнирыRow)(this.GetParentRow(this.Table.ParentRelations["ТурнирыСетки"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["ТурнирыСетки"]);
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКод_турнираNull() {
                return this.IsNull(this.tableСетки.Код_турнираColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКод_турнираNull() {
                this[this.tableСетки.Код_турнираColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКод_участника_1Null() {
                return this.IsNull(this.tableСетки.Код_участника_1Column);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКод_участника_1Null() {
                this[this.tableСетки.Код_участника_1Column] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКод_участника_2Null() {
                return this.IsNull(this.tableСетки.Код_участника_2Column);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКод_участника_2Null() {
                this[this.tableСетки.Код_участника_2Column] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsСчёт_первого_сетаNull() {
                return this.IsNull(this.tableСетки.Счёт_первого_сетаColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetСчёт_первого_сетаNull() {
                this[this.tableСетки.Счёт_первого_сетаColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsСчёт_второго_сетаNull() {
                return this.IsNull(this.tableСетки.Счёт_второго_сетаColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetСчёт_второго_сетаNull() {
                this[this.tableСетки.Счёт_второго_сетаColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsСчёт_третьего_сетаNull() {
                return this.IsNull(this.tableСетки.Счёт_третьего_сетаColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetСчёт_третьего_сетаNull() {
                this[this.tableСетки.Счёт_третьего_сетаColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsПобедительNull() {
                return this.IsNull(this.tableСетки.ПобедительColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetПобедительNull() {
                this[this.tableСетки.ПобедительColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsЭтапNull() {
                return this.IsNull(this.tableСетки.ЭтапColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetЭтапNull() {
                this[this.tableСетки.ЭтапColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsМестоNull() {
                return this.IsNull(this.tableСетки.МестоColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetМестоNull() {
                this[this.tableСетки.МестоColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public РасписаниеRow[] GetРасписаниеRows() {
                if ((this.Table.ChildRelations["СеткиРасписание"] == null)) {
                    return new РасписаниеRow[0];
                }
                else {
                    return ((РасписаниеRow[])(base.GetChildRows(this.Table.ChildRelations["СеткиРасписание"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class Списки_участниковRow : global::System.Data.DataRow {
            
            private Списки_участниковDataTable tableСписки_участников;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal Списки_участниковRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableСписки_участников = ((Списки_участниковDataTable)(this.Table));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_учаcтника {
                get {
                    return ((int)(this[this.tableСписки_участников.Код_учаcтникаColumn]));
                }
                set {
                    this[this.tableСписки_участников.Код_учаcтникаColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_турнира {
                get {
                    try {
                        return ((int)(this[this.tableСписки_участников.Код_турнираColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Код турнира\' в таблице \'Списки участников\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСписки_участников.Код_турнираColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_игрока_1 {
                get {
                    try {
                        return ((int)(this[this.tableСписки_участников.Код_игрока_1Column]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Код игрока 1\' в таблице \'Списки участников\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСписки_участников.Код_игрока_1Column] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_игрока_2 {
                get {
                    try {
                        return ((int)(this[this.tableСписки_участников.Код_игрока_2Column]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Код игрока 2\' в таблице \'Списки участников\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСписки_участников.Код_игрока_2Column] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_игроковRow Справочник_игроковRowByСправочник_игроковСписки_участников {
                get {
                    return ((Справочник_игроковRow)(this.GetParentRow(this.Table.ParentRelations["Справочник игроковСписки участников"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Справочник игроковСписки участников"]);
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_игроковRow Справочник_игроковRowByСправочник_игроковСписки_участников1 {
                get {
                    return ((Справочник_игроковRow)(this.GetParentRow(this.Table.ParentRelations["Справочник игроковСписки участников1"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Справочник игроковСписки участников1"]);
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public ТурнирыRow ТурнирыRow {
                get {
                    return ((ТурнирыRow)(this.GetParentRow(this.Table.ParentRelations["ТурнирыСписки участников"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["ТурнирыСписки участников"]);
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКод_турнираNull() {
                return this.IsNull(this.tableСписки_участников.Код_турнираColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКод_турнираNull() {
                this[this.tableСписки_участников.Код_турнираColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКод_игрока_1Null() {
                return this.IsNull(this.tableСписки_участников.Код_игрока_1Column);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКод_игрока_1Null() {
                this[this.tableСписки_участников.Код_игрока_1Column] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКод_игрока_2Null() {
                return this.IsNull(this.tableСписки_участников.Код_игрока_2Column);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКод_игрока_2Null() {
                this[this.tableСписки_участников.Код_игрока_2Column] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class Справочник_игроковRow : global::System.Data.DataRow {
            
            private Справочник_игроковDataTable tableСправочник_игроков;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal Справочник_игроковRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableСправочник_игроков = ((Справочник_игроковDataTable)(this.Table));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_игрока {
                get {
                    return ((int)(this[this.tableСправочник_игроков.Код_игрокаColumn]));
                }
                set {
                    this[this.tableСправочник_игроков.Код_игрокаColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Фамилия {
                get {
                    try {
                        return ((string)(this[this.tableСправочник_игроков.ФамилияColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Фамилия\' в таблице \'Справочник игроков\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСправочник_игроков.ФамилияColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Имя {
                get {
                    try {
                        return ((string)(this[this.tableСправочник_игроков.ИмяColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Имя\' в таблице \'Справочник игроков\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСправочник_игроков.ИмяColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Отчетсво {
                get {
                    try {
                        return ((string)(this[this.tableСправочник_игроков.ОтчетсвоColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Отчетсво\' в таблице \'Справочник игроков\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСправочник_игроков.ОтчетсвоColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public System.DateTime Дата_рождения {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableСправочник_игроков.Дата_рожденияColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Дата рождения\' в таблице \'Справочник игроков\' равно DBNull." +
                                "", e);
                    }
                }
                set {
                    this[this.tableСправочник_игроков.Дата_рожденияColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Город {
                get {
                    try {
                        return ((string)(this[this.tableСправочник_игроков.ГородColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Город\' в таблице \'Справочник игроков\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСправочник_игроков.ГородColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Мобильный_телефон {
                get {
                    try {
                        return ((string)(this[this.tableСправочник_игроков.Мобильный_телефонColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Мобильный телефон\' в таблице \'Справочник игроков\' равно DBN" +
                                "ull.", e);
                    }
                }
                set {
                    this[this.tableСправочник_игроков.Мобильный_телефонColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Рейтинг {
                get {
                    try {
                        return ((int)(this[this.tableСправочник_игроков.РейтингColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Рейтинг\' в таблице \'Справочник игроков\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСправочник_игроков.РейтингColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsФамилияNull() {
                return this.IsNull(this.tableСправочник_игроков.ФамилияColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetФамилияNull() {
                this[this.tableСправочник_игроков.ФамилияColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsИмяNull() {
                return this.IsNull(this.tableСправочник_игроков.ИмяColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetИмяNull() {
                this[this.tableСправочник_игроков.ИмяColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsОтчетсвоNull() {
                return this.IsNull(this.tableСправочник_игроков.ОтчетсвоColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetОтчетсвоNull() {
                this[this.tableСправочник_игроков.ОтчетсвоColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsДата_рожденияNull() {
                return this.IsNull(this.tableСправочник_игроков.Дата_рожденияColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetДата_рожденияNull() {
                this[this.tableСправочник_игроков.Дата_рожденияColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsГородNull() {
                return this.IsNull(this.tableСправочник_игроков.ГородColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetГородNull() {
                this[this.tableСправочник_игроков.ГородColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsМобильный_телефонNull() {
                return this.IsNull(this.tableСправочник_игроков.Мобильный_телефонColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetМобильный_телефонNull() {
                this[this.tableСправочник_игроков.Мобильный_телефонColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsРейтингNull() {
                return this.IsNull(this.tableСправочник_игроков.РейтингColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetРейтингNull() {
                this[this.tableСправочник_игроков.РейтингColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Списки_участниковRow[] GetСписки_участниковRowsByСправочник_игроковСписки_участников() {
                if ((this.Table.ChildRelations["Справочник игроковСписки участников"] == null)) {
                    return new Списки_участниковRow[0];
                }
                else {
                    return ((Списки_участниковRow[])(base.GetChildRows(this.Table.ChildRelations["Справочник игроковСписки участников"])));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Списки_участниковRow[] GetСписки_участниковRowsByСправочник_игроковСписки_участников1() {
                if ((this.Table.ChildRelations["Справочник игроковСписки участников1"] == null)) {
                    return new Списки_участниковRow[0];
                }
                else {
                    return ((Списки_участниковRow[])(base.GetChildRows(this.Table.ChildRelations["Справочник игроковСписки участников1"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class Справочник_катерогийRow : global::System.Data.DataRow {
            
            private Справочник_катерогийDataTable tableСправочник_катерогий;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal Справочник_катерогийRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableСправочник_катерогий = ((Справочник_катерогийDataTable)(this.Table));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_категории {
                get {
                    return ((int)(this[this.tableСправочник_катерогий.Код_категорииColumn]));
                }
                set {
                    this[this.tableСправочник_катерогий.Код_категорииColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Название_категории {
                get {
                    try {
                        return ((string)(this[this.tableСправочник_катерогий.Название_категорииColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Название категории\' в таблице \'Справочник катерогий\' равно " +
                                "DBNull.", e);
                    }
                }
                set {
                    this[this.tableСправочник_катерогий.Название_категорииColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Описание_категории {
                get {
                    try {
                        return ((string)(this[this.tableСправочник_катерогий.Описание_категорииColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Описание категории\' в таблице \'Справочник катерогий\' равно " +
                                "DBNull.", e);
                    }
                }
                set {
                    this[this.tableСправочник_катерогий.Описание_категорииColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsНазвание_категорииNull() {
                return this.IsNull(this.tableСправочник_катерогий.Название_категорииColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetНазвание_категорииNull() {
                this[this.tableСправочник_катерогий.Название_категорииColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsОписание_категорииNull() {
                return this.IsNull(this.tableСправочник_катерогий.Описание_категорииColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetОписание_категорииNull() {
                this[this.tableСправочник_катерогий.Описание_категорииColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public ТурнирыRow[] GetТурнирыRows() {
                if ((this.Table.ChildRelations["Справочник катерогийТурниры"] == null)) {
                    return new ТурнирыRow[0];
                }
                else {
                    return ((ТурнирыRow[])(base.GetChildRows(this.Table.ChildRelations["Справочник катерогийТурниры"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class Справочник_кортовRow : global::System.Data.DataRow {
            
            private Справочник_кортовDataTable tableСправочник_кортов;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal Справочник_кортовRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableСправочник_кортов = ((Справочник_кортовDataTable)(this.Table));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_корта {
                get {
                    return ((int)(this[this.tableСправочник_кортов.Код_кортаColumn]));
                }
                set {
                    this[this.tableСправочник_кортов.Код_кортаColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Название_корта {
                get {
                    try {
                        return ((string)(this[this.tableСправочник_кортов.Название_кортаColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Название корта\' в таблице \'Справочник кортов\' равно DBNull." +
                                "", e);
                    }
                }
                set {
                    this[this.tableСправочник_кортов.Название_кортаColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Расположение_корта {
                get {
                    try {
                        return ((string)(this[this.tableСправочник_кортов.Расположение_кортаColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Расположение корта\' в таблице \'Справочник кортов\' равно DBN" +
                                "ull.", e);
                    }
                }
                set {
                    this[this.tableСправочник_кортов.Расположение_кортаColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsНазвание_кортаNull() {
                return this.IsNull(this.tableСправочник_кортов.Название_кортаColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetНазвание_кортаNull() {
                this[this.tableСправочник_кортов.Название_кортаColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsРасположение_кортаNull() {
                return this.IsNull(this.tableСправочник_кортов.Расположение_кортаColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetРасположение_кортаNull() {
                this[this.tableСправочник_кортов.Расположение_кортаColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public ТурнирыRow[] GetТурнирыRowsByСправочник_кортовТурниры() {
                if ((this.Table.ChildRelations["Справочник кортовТурниры"] == null)) {
                    return new ТурнирыRow[0];
                }
                else {
                    return ((ТурнирыRow[])(base.GetChildRows(this.Table.ChildRelations["Справочник кортовТурниры"])));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public ТурнирыRow[] GetТурнирыRowsByСправочник_кортовТурниры1() {
                if ((this.Table.ChildRelations["Справочник кортовТурниры1"] == null)) {
                    return new ТурнирыRow[0];
                }
                else {
                    return ((ТурнирыRow[])(base.GetChildRows(this.Table.ChildRelations["Справочник кортовТурниры1"])));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public ТурнирыRow[] GetТурнирыRowsByСправочник_кортовТурниры2() {
                if ((this.Table.ChildRelations["Справочник кортовТурниры2"] == null)) {
                    return new ТурнирыRow[0];
                }
                else {
                    return ((ТурнирыRow[])(base.GetChildRows(this.Table.ChildRelations["Справочник кортовТурниры2"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class Справочник_систем_проведенияRow : global::System.Data.DataRow {
            
            private Справочник_систем_проведенияDataTable tableСправочник_систем_проведения;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal Справочник_систем_проведенияRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableСправочник_систем_проведения = ((Справочник_систем_проведенияDataTable)(this.Table));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_системы {
                get {
                    return ((int)(this[this.tableСправочник_систем_проведения.Код_системыColumn]));
                }
                set {
                    this[this.tableСправочник_систем_проведения.Код_системыColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Название_системы {
                get {
                    try {
                        return ((string)(this[this.tableСправочник_систем_проведения.Название_системыColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Название системы\' в таблице \'Справочник систем проведения\' " +
                                "равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСправочник_систем_проведения.Название_системыColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Описание_системы {
                get {
                    try {
                        return ((string)(this[this.tableСправочник_систем_проведения.Описание_системыColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Описание системы\' в таблице \'Справочник систем проведения\' " +
                                "равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСправочник_систем_проведения.Описание_системыColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsНазвание_системыNull() {
                return this.IsNull(this.tableСправочник_систем_проведения.Название_системыColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetНазвание_системыNull() {
                this[this.tableСправочник_систем_проведения.Название_системыColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsОписание_системыNull() {
                return this.IsNull(this.tableСправочник_систем_проведения.Описание_системыColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetОписание_системыNull() {
                this[this.tableСправочник_систем_проведения.Описание_системыColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_этапов_турнираRow[] GetСправочник_этапов_турнираRows() {
                if ((this.Table.ChildRelations["Справочник систем проведенияСправочник этапов турнира"] == null)) {
                    return new Справочник_этапов_турнираRow[0];
                }
                else {
                    return ((Справочник_этапов_турнираRow[])(base.GetChildRows(this.Table.ChildRelations["Справочник систем проведенияСправочник этапов турнира"])));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public ТурнирыRow[] GetТурнирыRows() {
                if ((this.Table.ChildRelations["Справочник систем проведенияТурниры"] == null)) {
                    return new ТурнирыRow[0];
                }
                else {
                    return ((ТурнирыRow[])(base.GetChildRows(this.Table.ChildRelations["Справочник систем проведенияТурниры"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class Справочник_этапов_турнираRow : global::System.Data.DataRow {
            
            private Справочник_этапов_турнираDataTable tableСправочник_этапов_турнира;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal Справочник_этапов_турнираRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableСправочник_этапов_турнира = ((Справочник_этапов_турнираDataTable)(this.Table));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_этапа {
                get {
                    return ((int)(this[this.tableСправочник_этапов_турнира.Код_этапаColumn]));
                }
                set {
                    this[this.tableСправочник_этапов_турнира.Код_этапаColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Этап {
                get {
                    try {
                        return ((string)(this[this.tableСправочник_этапов_турнира.ЭтапColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Этап\' в таблице \'Справочник этапов турнира\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСправочник_этапов_турнира.ЭтапColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_системы_проведения {
                get {
                    try {
                        return ((int)(this[this.tableСправочник_этапов_турнира.Код_системы_проведенияColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Код системы проведения\' в таблице \'Справочник этапов турнир" +
                                "а\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableСправочник_этапов_турнира.Код_системы_проведенияColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_систем_проведенияRow Справочник_систем_проведенияRow {
                get {
                    return ((Справочник_систем_проведенияRow)(this.GetParentRow(this.Table.ParentRelations["Справочник систем проведенияСправочник этапов турнира"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Справочник систем проведенияСправочник этапов турнира"]);
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsЭтапNull() {
                return this.IsNull(this.tableСправочник_этапов_турнира.ЭтапColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetЭтапNull() {
                this[this.tableСправочник_этапов_турнира.ЭтапColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКод_системы_проведенияNull() {
                return this.IsNull(this.tableСправочник_этапов_турнира.Код_системы_проведенияColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКод_системы_проведенияNull() {
                this[this.tableСправочник_этапов_турнира.Код_системы_проведенияColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public СеткиRow[] GetСеткиRows() {
                if ((this.Table.ChildRelations["Справочник этапов турнираСетки"] == null)) {
                    return new СеткиRow[0];
                }
                else {
                    return ((СеткиRow[])(base.GetChildRows(this.Table.ChildRelations["Справочник этапов турнираСетки"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class ТурнирыRow : global::System.Data.DataRow {
            
            private ТурнирыDataTable tableТурниры;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal ТурнирыRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableТурниры = ((ТурнирыDataTable)(this.Table));
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_турнира {
                get {
                    return ((int)(this[this.tableТурниры.Код_турнираColumn]));
                }
                set {
                    this[this.tableТурниры.Код_турнираColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Наименование {
                get {
                    try {
                        return ((string)(this[this.tableТурниры.НаименованиеColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Наименование\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.НаименованиеColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_категории {
                get {
                    try {
                        return ((int)(this[this.tableТурниры.Код_категорииColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Код категории\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.Код_категорииColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_системы_проведения {
                get {
                    try {
                        return ((int)(this[this.tableТурниры.Код_системы_проведенияColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Код системы проведения\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.Код_системы_проведенияColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Количество_участников {
                get {
                    try {
                        return ((int)(this[this.tableТурниры.Количество_участниковColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Количество участников\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.Количество_участниковColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Разряд {
                get {
                    try {
                        return ((string)(this[this.tableТурниры.РазрядColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Разряд\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.РазрядColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Количество_групп {
                get {
                    try {
                        return ((int)(this[this.tableТурниры.Количество_группColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Количество групп\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.Количество_группColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Дата_начала {
                get {
                    try {
                        return ((string)(this[this.tableТурниры.Дата_началаColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Дата начала\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.Дата_началаColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public System.DateTime Дата_конца {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableТурниры.Дата_концаColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Дата конца\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.Дата_концаColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Количество_кортов {
                get {
                    try {
                        return ((int)(this[this.tableТурниры.Количество_кортовColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Количество кортов\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.Количество_кортовColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_корта_1 {
                get {
                    try {
                        return ((int)(this[this.tableТурниры.Код_корта_1Column]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Код корта 1\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.Код_корта_1Column] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_корта_2 {
                get {
                    try {
                        return ((int)(this[this.tableТурниры.Код_корта_2Column]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Код корта 2\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.Код_корта_2Column] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Код_корта_3 {
                get {
                    try {
                        return ((int)(this[this.tableТурниры.Код_корта_3Column]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Код корта 3\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.Код_корта_3Column] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public System.DateTime Время_начала_проведения {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableТурниры.Время_начала_проведенияColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Время начала проведения\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.Время_начала_проведенияColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public System.DateTime Время_конца_проведения {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableТурниры.Время_конца_проведенияColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Время конца проведения\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.Время_конца_проведенияColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Длительность_матча {
                get {
                    try {
                        return ((int)(this[this.tableТурниры.Длительность_матчаColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Длительность матча\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.Длительность_матчаColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string ФИО_директора {
                get {
                    try {
                        return ((string)(this[this.tableТурниры.ФИО_директораColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'ФИО директора\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.ФИО_директораColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Телефон_директора {
                get {
                    try {
                        return ((string)(this[this.tableТурниры.Телефон_директораColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Телефон директора\' в таблице \'Турниры\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableТурниры.Телефон_директораColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int Количество_сеянных_участников {
                get {
                    try {
                        return ((int)(this[this.tableТурниры.Количество_сеянных_участниковColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Количество сеянных участников\' в таблице \'Турниры\' равно DB" +
                                "Null.", e);
                    }
                }
                set {
                    this[this.tableТурниры.Количество_сеянных_участниковColumn] = value;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_катерогийRow Справочник_катерогийRow {
                get {
                    return ((Справочник_катерогийRow)(this.GetParentRow(this.Table.ParentRelations["Справочник катерогийТурниры"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Справочник катерогийТурниры"]);
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_кортовRow Справочник_кортовRowByСправочник_кортовТурниры {
                get {
                    return ((Справочник_кортовRow)(this.GetParentRow(this.Table.ParentRelations["Справочник кортовТурниры"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Справочник кортовТурниры"]);
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_кортовRow Справочник_кортовRowByСправочник_кортовТурниры1 {
                get {
                    return ((Справочник_кортовRow)(this.GetParentRow(this.Table.ParentRelations["Справочник кортовТурниры1"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Справочник кортовТурниры1"]);
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_кортовRow Справочник_кортовRowByСправочник_кортовТурниры2 {
                get {
                    return ((Справочник_кортовRow)(this.GetParentRow(this.Table.ParentRelations["Справочник кортовТурниры2"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Справочник кортовТурниры2"]);
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_систем_проведенияRow Справочник_систем_проведенияRow {
                get {
                    return ((Справочник_систем_проведенияRow)(this.GetParentRow(this.Table.ParentRelations["Справочник систем проведенияТурниры"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Справочник систем проведенияТурниры"]);
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsНаименованиеNull() {
                return this.IsNull(this.tableТурниры.НаименованиеColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetНаименованиеNull() {
                this[this.tableТурниры.НаименованиеColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКод_категорииNull() {
                return this.IsNull(this.tableТурниры.Код_категорииColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКод_категорииNull() {
                this[this.tableТурниры.Код_категорииColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКод_системы_проведенияNull() {
                return this.IsNull(this.tableТурниры.Код_системы_проведенияColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКод_системы_проведенияNull() {
                this[this.tableТурниры.Код_системы_проведенияColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКоличество_участниковNull() {
                return this.IsNull(this.tableТурниры.Количество_участниковColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКоличество_участниковNull() {
                this[this.tableТурниры.Количество_участниковColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsРазрядNull() {
                return this.IsNull(this.tableТурниры.РазрядColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetРазрядNull() {
                this[this.tableТурниры.РазрядColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКоличество_группNull() {
                return this.IsNull(this.tableТурниры.Количество_группColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКоличество_группNull() {
                this[this.tableТурниры.Количество_группColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsДата_началаNull() {
                return this.IsNull(this.tableТурниры.Дата_началаColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetДата_началаNull() {
                this[this.tableТурниры.Дата_началаColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsДата_концаNull() {
                return this.IsNull(this.tableТурниры.Дата_концаColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetДата_концаNull() {
                this[this.tableТурниры.Дата_концаColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКоличество_кортовNull() {
                return this.IsNull(this.tableТурниры.Количество_кортовColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКоличество_кортовNull() {
                this[this.tableТурниры.Количество_кортовColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКод_корта_1Null() {
                return this.IsNull(this.tableТурниры.Код_корта_1Column);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКод_корта_1Null() {
                this[this.tableТурниры.Код_корта_1Column] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКод_корта_2Null() {
                return this.IsNull(this.tableТурниры.Код_корта_2Column);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКод_корта_2Null() {
                this[this.tableТурниры.Код_корта_2Column] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКод_корта_3Null() {
                return this.IsNull(this.tableТурниры.Код_корта_3Column);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКод_корта_3Null() {
                this[this.tableТурниры.Код_корта_3Column] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsВремя_начала_проведенияNull() {
                return this.IsNull(this.tableТурниры.Время_начала_проведенияColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetВремя_начала_проведенияNull() {
                this[this.tableТурниры.Время_начала_проведенияColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsВремя_конца_проведенияNull() {
                return this.IsNull(this.tableТурниры.Время_конца_проведенияColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetВремя_конца_проведенияNull() {
                this[this.tableТурниры.Время_конца_проведенияColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsДлительность_матчаNull() {
                return this.IsNull(this.tableТурниры.Длительность_матчаColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetДлительность_матчаNull() {
                this[this.tableТурниры.Длительность_матчаColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsФИО_директораNull() {
                return this.IsNull(this.tableТурниры.ФИО_директораColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetФИО_директораNull() {
                this[this.tableТурниры.ФИО_директораColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsТелефон_директораNull() {
                return this.IsNull(this.tableТурниры.Телефон_директораColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetТелефон_директораNull() {
                this[this.tableТурниры.Телефон_директораColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsКоличество_сеянных_участниковNull() {
                return this.IsNull(this.tableТурниры.Количество_сеянных_участниковColumn);
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetКоличество_сеянных_участниковNull() {
                this[this.tableТурниры.Количество_сеянных_участниковColumn] = global::System.Convert.DBNull;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public РасписаниеRow[] GetРасписаниеRows() {
                if ((this.Table.ChildRelations["ТурнирыРасписание"] == null)) {
                    return new РасписаниеRow[0];
                }
                else {
                    return ((РасписаниеRow[])(base.GetChildRows(this.Table.ChildRelations["ТурнирыРасписание"])));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public СеткиRow[] GetСеткиRows() {
                if ((this.Table.ChildRelations["ТурнирыСетки"] == null)) {
                    return new СеткиRow[0];
                }
                else {
                    return ((СеткиRow[])(base.GetChildRows(this.Table.ChildRelations["ТурнирыСетки"])));
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Списки_участниковRow[] GetСписки_участниковRows() {
                if ((this.Table.ChildRelations["ТурнирыСписки участников"] == null)) {
                    return new Списки_участниковRow[0];
                }
                else {
                    return ((Списки_участниковRow[])(base.GetChildRows(this.Table.ChildRelations["ТурнирыСписки участников"])));
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public class РасписаниеRowChangeEvent : global::System.EventArgs {
            
            private РасписаниеRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public РасписаниеRowChangeEvent(РасписаниеRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public РасписаниеRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public class СеткиRowChangeEvent : global::System.EventArgs {
            
            private СеткиRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public СеткиRowChangeEvent(СеткиRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public СеткиRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public class Списки_участниковRowChangeEvent : global::System.EventArgs {
            
            private Списки_участниковRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Списки_участниковRowChangeEvent(Списки_участниковRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Списки_участниковRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public class Справочник_игроковRowChangeEvent : global::System.EventArgs {
            
            private Справочник_игроковRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_игроковRowChangeEvent(Справочник_игроковRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_игроковRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public class Справочник_катерогийRowChangeEvent : global::System.EventArgs {
            
            private Справочник_катерогийRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_катерогийRowChangeEvent(Справочник_катерогийRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_катерогийRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public class Справочник_кортовRowChangeEvent : global::System.EventArgs {
            
            private Справочник_кортовRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_кортовRowChangeEvent(Справочник_кортовRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_кортовRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public class Справочник_систем_проведенияRowChangeEvent : global::System.EventArgs {
            
            private Справочник_систем_проведенияRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_систем_проведенияRowChangeEvent(Справочник_систем_проведенияRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_систем_проведенияRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public class Справочник_этапов_турнираRowChangeEvent : global::System.EventArgs {
            
            private Справочник_этапов_турнираRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_этапов_турнираRowChangeEvent(Справочник_этапов_турнираRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public Справочник_этапов_турнираRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public class ТурнирыRowChangeEvent : global::System.EventArgs {
            
            private ТурнирыRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public ТурнирыRowChangeEvent(ТурнирыRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public ТурнирыRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
namespace kp2_2.кп2_DataSetTableAdapters
{


    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class РасписаниеTableAdapter : global::System.ComponentModel.Component
    {

        private global::System.Data.OleDb.OleDbDataAdapter _adapter;

        private global::System.Data.OleDb.OleDbConnection _connection;

        private global::System.Data.OleDb.OleDbTransaction _transaction;

        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;

        private bool _clearBeforeFill;


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public РасписаниеTableAdapter()
        {
            this.ClearBeforeFill = true;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter
        {
            get
            {
                if ((this._adapter == null))
                {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection
        {
            get
            {
                if ((this._connection == null))
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    if ((this.CommandCollection[i] != null))
                    {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.DeleteCommand != null)))
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.InsertCommand != null)))
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.UpdateCommand != null)))
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public bool ClearBeforeFill
        {
            get
            {
                return this._clearBeforeFill;
            }
            set
            {
                this._clearBeforeFill = value;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Расписание";
            tableMapping.ColumnMappings.Add("Код матча", "Код матча");
            tableMapping.ColumnMappings.Add("Код турнира", "Код турнира");
            tableMapping.ColumnMappings.Add("Корт", "Корт");
            tableMapping.ColumnMappings.Add("Время начала", "Время начала");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitConnection()
        {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::kp2_2.Properties.Settings.Default.kp2ConnectionString;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT [Код матча], [Код турнира], Корт, [Время начала] FROM Расписание WHERE [Код турнира] = ***** ORDER BY [Время начала]";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(кп2_DataSet.РасписаниеDataTable dataTable, string code)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            this.Adapter.SelectCommand.CommandText = this.Adapter.SelectCommand.CommandText.Replace("*****", code);
            if ((this.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual кп2_DataSet.РасписаниеDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            кп2_DataSet.РасписаниеDataTable dataTable = new кп2_DataSet.РасписаниеDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet.РасписаниеDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "Расписание");
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow)
        {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(string code)
        {
            this._adapter.DeleteCommand.CommandText = "DELETE FROM [Расписание] WHERE [Код матча] = " + code;
            global::System.Data.ConnectionState previousConnectionState = this._adapter.DeleteCommand.Connection.State;
            if (((this._adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this._adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                int returnValue = this._adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this._adapter.DeleteCommand.Connection.Close();
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.Table_adapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string newelement)
        {
            this._adapter.InsertCommand.CommandText = "INSERT INTO [Расписание] VALUES (" + newelement + ")";
            global::System.Data.ConnectionState previousConnectionState = this._adapter.InsertCommand.Connection.State;
            if (((this._adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) != global::System.Data.ConnectionState.Open))
            {
                this._adapter.InsertCommand.Connection.Open();
            }
            try
            {
                int returnValue = this._adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this._adapter.InsertCommand.Connection.Close();
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.Table_adapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string newelement, string code)
        {
            this._adapter.UpdateCommand.CommandText = "UPDATE [Расписание] SET " + newelement + " WHERE [Код матча] = " + code;
            global::System.Data.ConnectionState previousConnectionState = this._adapter.UpdateCommand.Connection.State;
            if (((this._adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this._adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                int returnValue = this._adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this._adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }

    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class СеткиTableAdapter : global::System.ComponentModel.Component
    {

        private global::System.Data.OleDb.OleDbDataAdapter _adapter;

        private global::System.Data.OleDb.OleDbConnection _connection;

        private global::System.Data.OleDb.OleDbTransaction _transaction;

        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;

        private bool _clearBeforeFill;


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public СеткиTableAdapter()
        {
            this.ClearBeforeFill = true;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter
        {
            get
            {
                if ((this._adapter == null))
                {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection
        {
            get
            {
                if ((this._connection == null))
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    if ((this.CommandCollection[i] != null))
                    {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.DeleteCommand != null)))
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.InsertCommand != null)))
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.UpdateCommand != null)))
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public bool ClearBeforeFill
        {
            get
            {
                return this._clearBeforeFill;
            }
            set
            {
                this._clearBeforeFill = value;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Сетки";
            tableMapping.ColumnMappings.Add("Код матча", "Код матча");
            tableMapping.ColumnMappings.Add("Код турнира", "Код турнира");
            tableMapping.ColumnMappings.Add("Код участника 1", "Код участника 1");
            tableMapping.ColumnMappings.Add("Код участника 2", "Код участника 2");
            tableMapping.ColumnMappings.Add("Счёт первого сета", "Счёт первого сета");
            tableMapping.ColumnMappings.Add("Счёт второго сета", "Счёт второго сета");
            tableMapping.ColumnMappings.Add("Счёт третьего сета", "Счёт третьего сета");
            tableMapping.ColumnMappings.Add("Победитель", "Победитель");
            tableMapping.ColumnMappings.Add("Этап", "Этап");
            tableMapping.ColumnMappings.Add("Место", "Место");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM `Сетки` WHERE ((`Код матча` = ?) AND ((? = 1 AND `Код турнира` IS NULL) OR (`Код турнира` = ?)) AND ((? = 1 AND `Код участника 1` IS NULL) OR (`Код участника 1` = ?)) AND ((? = 1 AND `Код участника 2` IS NULL) OR (`Код участника 2` = ?)) AND ((? = 1 AND `Счёт первого сета` IS NULL) OR (`Счёт первого сета` = ?)) AND ((? = 1 AND `Счёт второго сета` IS NULL) OR (`Счёт второго сета` = ?)) AND ((? = 1 AND `Счёт третьего сета` IS NULL) OR (`Счёт третьего сета` = ?)) AND ((? = 1 AND `Победитель` IS NULL) OR (`Победитель` = ?)) AND ((? = 1 AND `Этап` IS NULL) OR (`Этап` = ?)) AND ((? = 1 AND `Место` IS NULL) OR (`Место` = ?)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_матча", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код матча", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Код_турнира", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код турнира", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_турнира", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код турнира", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Код_участника_1", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код участника 1", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_участника_1", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код участника 1", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Код_участника_2", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код участника 2", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_участника_2", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код участника 2", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Счёт_первого_сета", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт первого сета", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Счёт_первого_сета", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт первого сета", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Счёт_второго_сета", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт второго сета", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Счёт_второго_сета", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт второго сета", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Счёт_третьего_сета", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт третьего сета", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Счёт_третьего_сета", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт третьего сета", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Победитель", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Победитель", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Победитель", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Победитель", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Этап", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Этап", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Этап", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Этап", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Место", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Место", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Место", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Место", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `Сетки` (`Код турнира`, `Код участника 1`, `Код участника 2`, `Счёт п" +
                "ервого сета`, `Счёт второго сета`, `Счёт третьего сета`, `Победитель`, `Этап`, `" +
                "Место`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Код_турнира", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код турнира", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Код_участника_1", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код участника 1", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Код_участника_2", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код участника 2", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Счёт_первого_сета", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт первого сета", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Счёт_второго_сета", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт второго сета", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Счёт_третьего_сета", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт третьего сета", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Победитель", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Победитель", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Этап", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Этап", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Место", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Место", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE `Сетки` SET `Код турнира` = ?, `Код участника 1` = ?, `Код участника 2` = ?, `Счёт первого сета` = ?, `Счёт второго сета` = ?, `Счёт третьего сета` = ?, `Победитель` = ?, `Этап` = ?, `Место` = ? WHERE ((`Код матча` = ?) AND ((? = 1 AND `Код турнира` IS NULL) OR (`Код турнира` = ?)) AND ((? = 1 AND `Код участника 1` IS NULL) OR (`Код участника 1` = ?)) AND ((? = 1 AND `Код участника 2` IS NULL) OR (`Код участника 2` = ?)) AND ((? = 1 AND `Счёт первого сета` IS NULL) OR (`Счёт первого сета` = ?)) AND ((? = 1 AND `Счёт второго сета` IS NULL) OR (`Счёт второго сета` = ?)) AND ((? = 1 AND `Счёт третьего сета` IS NULL) OR (`Счёт третьего сета` = ?)) AND ((? = 1 AND `Победитель` IS NULL) OR (`Победитель` = ?)) AND ((? = 1 AND `Этап` IS NULL) OR (`Этап` = ?)) AND ((? = 1 AND `Место` IS NULL) OR (`Место` = ?)))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Код_турнира", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код турнира", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Код_участника_1", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код участника 1", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Код_участника_2", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код участника 2", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Счёт_первого_сета", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт первого сета", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Счёт_второго_сета", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт второго сета", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Счёт_третьего_сета", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт третьего сета", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Победитель", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Победитель", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Этап", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Этап", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Место", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Место", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_матча", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код матча", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Код_турнира", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код турнира", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_турнира", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код турнира", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Код_участника_1", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код участника 1", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_участника_1", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код участника 1", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Код_участника_2", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код участника 2", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_участника_2", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код участника 2", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Счёт_первого_сета", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт первого сета", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Счёт_первого_сета", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт первого сета", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Счёт_второго_сета", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт второго сета", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Счёт_второго_сета", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт второго сета", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Счёт_третьего_сета", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт третьего сета", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Счёт_третьего_сета", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Счёт третьего сета", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Победитель", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Победитель", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Победитель", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Победитель", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Этап", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Этап", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Этап", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Этап", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Место", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Место", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Место", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Место", global::System.Data.DataRowVersion.Original, false, null));
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitConnection()
        {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::kp2_2.Properties.Settings.Default.kp2ConnectionString;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT [Код матча], [Код турнира], [Код участника 1], [Код участника 2], [Счёт пе" +
                "рвого сета], [Счёт второго сета], [Счёт третьего сета], Победитель, Этап, Место " +
                "FROM Сетки";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(кп2_DataSet.СеткиDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual кп2_DataSet.СеткиDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            кп2_DataSet.СеткиDataTable dataTable = new кп2_DataSet.СеткиDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet.СеткиDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "Сетки");
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow)
        {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_Код_матча, global::System.Nullable<int> Original_Код_турнира, global::System.Nullable<int> Original_Код_участника_1, global::System.Nullable<int> Original_Код_участника_2, string Original_Счёт_первого_сета, string Original_Счёт_второго_сета, string Original_Счёт_третьего_сета, global::System.Nullable<int> Original_Победитель, global::System.Nullable<int> Original_Этап, global::System.Nullable<int> Original_Место)
        {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_Код_матча));
            if ((Original_Код_турнира.HasValue == true))
            {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((int)(Original_Код_турнира.Value));
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((Original_Код_участника_1.HasValue == true))
            {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((int)(Original_Код_участника_1.Value));
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Original_Код_участника_2.HasValue == true))
            {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[6].Value = ((int)(Original_Код_участника_2.Value));
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Original_Счёт_первого_сета == null))
            {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[8].Value = ((string)(Original_Счёт_первого_сета));
            }
            if ((Original_Счёт_второго_сета == null))
            {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[10].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[10].Value = ((string)(Original_Счёт_второго_сета));
            }
            if ((Original_Счёт_третьего_сета == null))
            {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[12].Value = ((string)(Original_Счёт_третьего_сета));
            }
            if ((Original_Победитель.HasValue == true))
            {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[14].Value = ((int)(Original_Победитель.Value));
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            if ((Original_Этап.HasValue == true))
            {
                this.Adapter.DeleteCommand.Parameters[15].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[16].Value = ((int)(Original_Этап.Value));
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[15].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[16].Value = global::System.DBNull.Value;
            }
            if ((Original_Место.HasValue == true))
            {
                this.Adapter.DeleteCommand.Parameters[17].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[18].Value = ((int)(Original_Место.Value));
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[17].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[18].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(global::System.Nullable<int> Код_турнира, global::System.Nullable<int> Код_участника_1, global::System.Nullable<int> Код_участника_2, string Счёт_первого_сета, string Счёт_второго_сета, string Счёт_третьего_сета, global::System.Nullable<int> Победитель, global::System.Nullable<int> Этап, global::System.Nullable<int> Место)
        {
            if ((Код_турнира.HasValue == true))
            {
                this.Adapter.InsertCommand.Parameters[0].Value = ((int)(Код_турнира.Value));
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            if ((Код_участника_1.HasValue == true))
            {
                this.Adapter.InsertCommand.Parameters[1].Value = ((int)(Код_участника_1.Value));
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((Код_участника_2.HasValue == true))
            {
                this.Adapter.InsertCommand.Parameters[2].Value = ((int)(Код_участника_2.Value));
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((Счёт_первого_сета == null))
            {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[3].Value = ((string)(Счёт_первого_сета));
            }
            if ((Счёт_второго_сета == null))
            {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[4].Value = ((string)(Счёт_второго_сета));
            }
            if ((Счёт_третьего_сета == null))
            {
                this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[5].Value = ((string)(Счёт_третьего_сета));
            }
            if ((Победитель.HasValue == true))
            {
                this.Adapter.InsertCommand.Parameters[6].Value = ((int)(Победитель.Value));
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Этап.HasValue == true))
            {
                this.Adapter.InsertCommand.Parameters[7].Value = ((int)(Этап.Value));
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            if ((Место.HasValue == true))
            {
                this.Adapter.InsertCommand.Parameters[8].Value = ((int)(Место.Value));
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    global::System.Nullable<int> Код_турнира,
                    global::System.Nullable<int> Код_участника_1,
                    global::System.Nullable<int> Код_участника_2,
                    string Счёт_первого_сета,
                    string Счёт_второго_сета,
                    string Счёт_третьего_сета,
                    global::System.Nullable<int> Победитель,
                    global::System.Nullable<int> Этап,
                    global::System.Nullable<int> Место,
                    int Original_Код_матча,
                    global::System.Nullable<int> Original_Код_турнира,
                    global::System.Nullable<int> Original_Код_участника_1,
                    global::System.Nullable<int> Original_Код_участника_2,
                    string Original_Счёт_первого_сета,
                    string Original_Счёт_второго_сета,
                    string Original_Счёт_третьего_сета,
                    global::System.Nullable<int> Original_Победитель,
                    global::System.Nullable<int> Original_Этап,
                    global::System.Nullable<int> Original_Место)
        {
            if ((Код_турнира.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((int)(Код_турнира.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            if ((Код_участника_1.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((int)(Код_участника_1.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((Код_участника_2.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((int)(Код_участника_2.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((Счёт_первого_сета == null))
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((string)(Счёт_первого_сета));
            }
            if ((Счёт_второго_сета == null))
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((string)(Счёт_второго_сета));
            }
            if ((Счёт_третьего_сета == null))
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((string)(Счёт_третьего_сета));
            }
            if ((Победитель.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((int)(Победитель.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Этап.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[7].Value = ((int)(Этап.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            if ((Место.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((int)(Место.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[9].Value = ((int)(Original_Код_матча));
            if ((Original_Код_турнира.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[11].Value = ((int)(Original_Код_турнира.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[11].Value = global::System.DBNull.Value;
            }
            if ((Original_Код_участника_1.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[12].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[13].Value = ((int)(Original_Код_участника_1.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[12].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[13].Value = global::System.DBNull.Value;
            }
            if ((Original_Код_участника_2.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[15].Value = ((int)(Original_Код_участника_2.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[15].Value = global::System.DBNull.Value;
            }
            if ((Original_Счёт_первого_сета == null))
            {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[17].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[17].Value = ((string)(Original_Счёт_первого_сета));
            }
            if ((Original_Счёт_второго_сета == null))
            {
                this.Adapter.UpdateCommand.Parameters[18].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[19].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[18].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[19].Value = ((string)(Original_Счёт_второго_сета));
            }
            if ((Original_Счёт_третьего_сета == null))
            {
                this.Adapter.UpdateCommand.Parameters[20].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[21].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[20].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[21].Value = ((string)(Original_Счёт_третьего_сета));
            }
            if ((Original_Победитель.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[22].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[23].Value = ((int)(Original_Победитель.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[22].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[23].Value = global::System.DBNull.Value;
            }
            if ((Original_Этап.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[24].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[25].Value = ((int)(Original_Этап.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[24].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[25].Value = global::System.DBNull.Value;
            }
            if ((Original_Место.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[26].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[27].Value = ((int)(Original_Место.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[26].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[27].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }

    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class Списки_участниковTableAdapter : global::System.ComponentModel.Component
    {

        private global::System.Data.OleDb.OleDbDataAdapter _adapter;

        private global::System.Data.OleDb.OleDbConnection _connection;

        private global::System.Data.OleDb.OleDbTransaction _transaction;

        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;

        private bool _clearBeforeFill;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public Списки_участниковTableAdapter()
        {
            this.ClearBeforeFill = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter
        {
            get
            {
                if ((this._adapter == null))
                {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection
        {
            get
            {
                if ((this._connection == null))
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    if ((this.CommandCollection[i] != null))
                    {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.DeleteCommand != null)))
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.InsertCommand != null)))
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.UpdateCommand != null)))
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public bool ClearBeforeFill
        {
            get
            {
                return this._clearBeforeFill;
            }
            set
            {
                this._clearBeforeFill = value;
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Списки участников";
            tableMapping.ColumnMappings.Add("Код учаcтника", "Код учаcтника");
            tableMapping.ColumnMappings.Add("Код турнира", "Код турнира");
            tableMapping.ColumnMappings.Add("Код игрока 1", "Код игрока 1");
            tableMapping.ColumnMappings.Add("Код игрока 2", "Код игрока 2");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitConnection()
        {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::kp2_2.Properties.Settings.Default.kp2ConnectionString;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT [Код учаcтника], [Код турнира], [Код игрока 1], [Код игрока 2] FROM [Списки участников] WHERE [Код турнира] = ***** ORDER BY [Код учаcтника]";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(кп2_DataSet.Списки_участниковDataTable dataTable, string code)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            this.Adapter.SelectCommand.CommandText = this.Adapter.SelectCommand.CommandText.Replace("*****", code);
            if ((this.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual кп2_DataSet.Списки_участниковDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            кп2_DataSet.Списки_участниковDataTable dataTable = new кп2_DataSet.Списки_участниковDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet.Списки_участниковDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "Списки участников");
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow)
        {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(string code)
        {
            this._adapter.DeleteCommand.CommandText = "DELETE FROM [Списки участников] WHERE [Код участника] = " + code;
            global::System.Data.ConnectionState previousConnectionState = this._adapter.DeleteCommand.Connection.State;
            if (((this._adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this._adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                int returnValue = this._adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this._adapter.DeleteCommand.Connection.Close();
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string newelement)
        {
            this._adapter.InsertCommand.CommandText = "INSERT INTO [Списки участников] VALUES (" + newelement + ")";
            global::System.Data.ConnectionState previousConnectionState = this._adapter.InsertCommand.Connection.State;
            if (((this._adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) != global::System.Data.ConnectionState.Open))
            {
                this._adapter.InsertCommand.Connection.Open();
            }
            try
            {
                int returnValue = this._adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this._adapter.InsertCommand.Connection.Close();
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string newelement, string code)
        {
            this._adapter.UpdateCommand.CommandText = "UPDATE [Списки участников] SET " + newelement + " WHERE [Код участника] = " + code;
            global::System.Data.ConnectionState previousConnectionState = this._adapter.UpdateCommand.Connection.State;
            if (((this._adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this._adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                int returnValue = this._adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this._adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }

    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class Справочник_игроковTableAdapter : global::System.ComponentModel.Component
    {

        private global::System.Data.OleDb.OleDbDataAdapter _adapter;

        private global::System.Data.OleDb.OleDbConnection _connection;

        private global::System.Data.OleDb.OleDbTransaction _transaction;

        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;

        private bool _clearBeforeFill;


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public Справочник_игроковTableAdapter()
        {
            this.ClearBeforeFill = true;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter
        {
            get
            {
                if ((this._adapter == null))
                {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection
        {
            get
            {
                if ((this._connection == null))
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    if ((this.CommandCollection[i] != null))
                    {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.DeleteCommand != null)))
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.InsertCommand != null)))
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.UpdateCommand != null)))
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public bool ClearBeforeFill
        {
            get
            {
                return this._clearBeforeFill;
            }
            set
            {
                this._clearBeforeFill = value;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Справочник игроков";
            tableMapping.ColumnMappings.Add("Код игрока", "Код игрока");
            tableMapping.ColumnMappings.Add("Фамилия", "Фамилия");
            tableMapping.ColumnMappings.Add("Имя", "Имя");
            tableMapping.ColumnMappings.Add("Отчетсво", "Отчетсво");
            tableMapping.ColumnMappings.Add("Дата рождения", "Дата рождения");
            tableMapping.ColumnMappings.Add("Город", "Город");
            tableMapping.ColumnMappings.Add("Мобильный телефон", "Мобильный телефон");
            tableMapping.ColumnMappings.Add("Рейтинг", "Рейтинг");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM `Справочник игроков` WHERE ((`Код игрока` = ?) AND ((? = 1 AND `Фамилия` IS NULL) OR (`Фамилия` = ?)) AND ((? = 1 AND `Имя` IS NULL) OR (`Имя` = ?)) AND ((? = 1 AND `Отчетсво` IS NULL) OR (`Отчетсво` = ?)) AND ((? = 1 AND `Дата рождения` IS NULL) OR (`Дата рождения` = ?)) AND ((? = 1 AND `Город` IS NULL) OR (`Город` = ?)) AND ((? = 1 AND `Мобильный телефон` IS NULL) OR (`Мобильный телефон` = ?)) AND ((? = 1 AND `Рейтинг` IS NULL) OR (`Рейтинг` = ?)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_игрока", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код игрока", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Фамилия", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Фамилия", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Имя", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Имя", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Отчетсво", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчетсво", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Отчетсво", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчетсво", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Дата_рождения", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата рождения", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Дата_рождения", global::System.Data.OleDb.OleDbType.Date, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата рождения", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Город", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Город", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Город", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Город", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Мобильный_телефон", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Мобильный телефон", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Мобильный_телефон", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Мобильный телефон", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Рейтинг", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Рейтинг", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Рейтинг", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Рейтинг", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `Справочник игроков` (`Фамилия`, `Имя`, `Отчетсво`, `Дата рождения`, " +
                "`Город`, `Мобильный телефон`, `Рейтинг`) VALUES (?, ?, ?, ?, ?, ?, ?)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Фамилия", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Имя", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Отчетсво", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчетсво", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Дата_рождения", global::System.Data.OleDb.OleDbType.Date, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата рождения", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Город", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Город", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Мобильный_телефон", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Мобильный телефон", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Рейтинг", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Рейтинг", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE `Справочник игроков` SET `Фамилия` = ?, `Имя` = ?, `Отчетсво` = ?, `Дата рождения` = ?, `Город` = ?, `Мобильный телефон` = ?, `Рейтинг` = ? WHERE ((`Код игрока` = ?) AND ((? = 1 AND `Фамилия` IS NULL) OR (`Фамилия` = ?)) AND ((? = 1 AND `Имя` IS NULL) OR (`Имя` = ?)) AND ((? = 1 AND `Отчетсво` IS NULL) OR (`Отчетсво` = ?)) AND ((? = 1 AND `Дата рождения` IS NULL) OR (`Дата рождения` = ?)) AND ((? = 1 AND `Город` IS NULL) OR (`Город` = ?)) AND ((? = 1 AND `Мобильный телефон` IS NULL) OR (`Мобильный телефон` = ?)) AND ((? = 1 AND `Рейтинг` IS NULL) OR (`Рейтинг` = ?)))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Фамилия", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Имя", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Отчетсво", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчетсво", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Дата_рождения", global::System.Data.OleDb.OleDbType.Date, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата рождения", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Город", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Город", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Мобильный_телефон", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Мобильный телефон", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Рейтинг", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Рейтинг", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_игрока", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код игрока", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Фамилия", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Фамилия", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Имя", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Имя", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Отчетсво", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчетсво", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Отчетсво", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчетсво", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Дата_рождения", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата рождения", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Дата_рождения", global::System.Data.OleDb.OleDbType.Date, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата рождения", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Город", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Город", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Город", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Город", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Мобильный_телефон", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Мобильный телефон", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Мобильный_телефон", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Мобильный телефон", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Рейтинг", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Рейтинг", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Рейтинг", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Рейтинг", global::System.Data.DataRowVersion.Original, false, null));
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitConnection()
        {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::kp2_2.Properties.Settings.Default.kp2ConnectionString;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT [Код игрока], Фамилия, Имя, Отчетсво, [Дата рождения], Город, [Мобильный т" +
                "елефон], Рейтинг FROM [Справочник игроков]";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(кп2_DataSet.Справочник_игроковDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual кп2_DataSet.Справочник_игроковDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            кп2_DataSet.Справочник_игроковDataTable dataTable = new кп2_DataSet.Справочник_игроковDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet.Справочник_игроковDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "Справочник игроков");
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow)
        {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_Код_игрока, string Original_Фамилия, string Original_Имя, string Original_Отчетсво, global::System.Nullable<global::System.DateTime> Original_Дата_рождения, string Original_Город, string Original_Мобильный_телефон, global::System.Nullable<int> Original_Рейтинг)
        {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_Код_игрока));
            if ((Original_Фамилия == null))
            {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((string)(Original_Фамилия));
            }
            if ((Original_Имя == null))
            {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((string)(Original_Имя));
            }
            if ((Original_Отчетсво == null))
            {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[6].Value = ((string)(Original_Отчетсво));
            }
            if ((Original_Дата_рождения.HasValue == true))
            {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[8].Value = ((System.DateTime)(Original_Дата_рождения.Value));
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((Original_Город == null))
            {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[10].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[10].Value = ((string)(Original_Город));
            }
            if ((Original_Мобильный_телефон == null))
            {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[12].Value = ((string)(Original_Мобильный_телефон));
            }
            if ((Original_Рейтинг.HasValue == true))
            {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[14].Value = ((int)(Original_Рейтинг.Value));
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string Фамилия, string Имя, string Отчетсво, global::System.Nullable<global::System.DateTime> Дата_рождения, string Город, string Мобильный_телефон, global::System.Nullable<int> Рейтинг)
        {
            if ((Фамилия == null))
            {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(Фамилия));
            }
            if ((Имя == null))
            {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(Имя));
            }
            if ((Отчетсво == null))
            {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(Отчетсво));
            }
            if ((Дата_рождения.HasValue == true))
            {
                this.Adapter.InsertCommand.Parameters[3].Value = ((System.DateTime)(Дата_рождения.Value));
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((Город == null))
            {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[4].Value = ((string)(Город));
            }
            if ((Мобильный_телефон == null))
            {
                this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[5].Value = ((string)(Мобильный_телефон));
            }
            if ((Рейтинг.HasValue == true))
            {
                this.Adapter.InsertCommand.Parameters[6].Value = ((int)(Рейтинг.Value));
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string Фамилия, string Имя, string Отчетсво, global::System.Nullable<global::System.DateTime> Дата_рождения, string Город, string Мобильный_телефон, global::System.Nullable<int> Рейтинг, int Original_Код_игрока, string Original_Фамилия, string Original_Имя, string Original_Отчетсво, global::System.Nullable<global::System.DateTime> Original_Дата_рождения, string Original_Город, string Original_Мобильный_телефон, global::System.Nullable<int> Original_Рейтинг)
        {
            if ((Фамилия == null))
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(Фамилия));
            }
            if ((Имя == null))
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(Имя));
            }
            if ((Отчетсво == null))
            {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(Отчетсво));
            }
            if ((Дата_рождения.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((System.DateTime)(Дата_рождения.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((Город == null))
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((string)(Город));
            }
            if ((Мобильный_телефон == null))
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((string)(Мобильный_телефон));
            }
            if ((Рейтинг.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((int)(Рейтинг.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[7].Value = ((int)(Original_Код_игрока));
            if ((Original_Фамилия == null))
            {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[9].Value = ((string)(Original_Фамилия));
            }
            if ((Original_Имя == null))
            {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[11].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[11].Value = ((string)(Original_Имя));
            }
            if ((Original_Отчетсво == null))
            {
                this.Adapter.UpdateCommand.Parameters[12].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[13].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[12].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[13].Value = ((string)(Original_Отчетсво));
            }
            if ((Original_Дата_рождения.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[15].Value = ((System.DateTime)(Original_Дата_рождения.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[15].Value = global::System.DBNull.Value;
            }
            if ((Original_Город == null))
            {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[17].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[17].Value = ((string)(Original_Город));
            }
            if ((Original_Мобильный_телефон == null))
            {
                this.Adapter.UpdateCommand.Parameters[18].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[19].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[18].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[19].Value = ((string)(Original_Мобильный_телефон));
            }
            if ((Original_Рейтинг.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[20].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[21].Value = ((int)(Original_Рейтинг.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[20].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[21].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }

    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class Справочник_катерогийTableAdapter : global::System.ComponentModel.Component
    {

        private global::System.Data.OleDb.OleDbDataAdapter _adapter;

        private global::System.Data.OleDb.OleDbConnection _connection;

        private global::System.Data.OleDb.OleDbTransaction _transaction;

        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;

        private bool _clearBeforeFill;


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public Справочник_катерогийTableAdapter()
        {
            this.ClearBeforeFill = true;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter
        {
            get
            {
                if ((this._adapter == null))
                {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection
        {
            get
            {
                if ((this._connection == null))
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    if ((this.CommandCollection[i] != null))
                    {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.DeleteCommand != null)))
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.InsertCommand != null)))
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.UpdateCommand != null)))
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public bool ClearBeforeFill
        {
            get
            {
                return this._clearBeforeFill;
            }
            set
            {
                this._clearBeforeFill = value;
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Справочник катерогий";
            tableMapping.ColumnMappings.Add("Код категории", "Код категории");
            tableMapping.ColumnMappings.Add("Название категории", "Название категории");
            tableMapping.ColumnMappings.Add("Описание категории", "Описание категории");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitConnection()
        {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::kp2_2.Properties.Settings.Default.kp2ConnectionString;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT [Код категории], [Название категории], [Описание категории] FROM [Справочн" +
                "ик катерогий]";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(кп2_DataSet.Справочник_катерогийDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual кп2_DataSet.Справочник_катерогийDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            кп2_DataSet.Справочник_катерогийDataTable dataTable = new кп2_DataSet.Справочник_катерогийDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet.Справочник_катерогийDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "Справочник катерогий");
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow)
        {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(string code)
        {
            this._adapter.DeleteCommand.CommandText = "DELETE FROM [Справочник катерогий] WHERE [Код категории] = " + code;
            global::System.Data.ConnectionState previousConnectionState = this._adapter.DeleteCommand.Connection.State;
            if (((this._adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this._adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                int returnValue = this._adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this._adapter.DeleteCommand.Connection.Close();
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string newelement)
        {
            this._adapter.InsertCommand.CommandText = "INSERT INTO [Справочник катерогий] VALUES (" + newelement + ")";
            global::System.Data.ConnectionState previousConnectionState = this._adapter.InsertCommand.Connection.State;
            if (((this._adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) != global::System.Data.ConnectionState.Open))
            {
                this._adapter.InsertCommand.Connection.Open();
            }
            try
            {
                int returnValue = this._adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this._adapter.InsertCommand.Connection.Close();
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string newelement, string code)
        {
            this._adapter.UpdateCommand.CommandText = "UPDATE [Справочник катерогий] SET " + newelement + " WHERE [Код категории] = " + code;
            global::System.Data.ConnectionState previousConnectionState = this._adapter.UpdateCommand.Connection.State;
            if (((this._adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this._adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                int returnValue = this._adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this._adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }

    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class Справочник_кортовTableAdapter : global::System.ComponentModel.Component
    {

        private global::System.Data.OleDb.OleDbDataAdapter _adapter;

        private global::System.Data.OleDb.OleDbConnection _connection;

        private global::System.Data.OleDb.OleDbTransaction _transaction;

        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;

        private bool _clearBeforeFill;


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public Справочник_кортовTableAdapter()
        {
            this.ClearBeforeFill = true;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter
        {
            get
            {
                if ((this._adapter == null))
                {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection
        {
            get
            {
                if ((this._connection == null))
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    if ((this.CommandCollection[i] != null))
                    {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.DeleteCommand != null)))
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.InsertCommand != null)))
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.UpdateCommand != null)))
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public bool ClearBeforeFill
        {
            get
            {
                return this._clearBeforeFill;
            }
            set
            {
                this._clearBeforeFill = value;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Справочник кортов";
            tableMapping.ColumnMappings.Add("Код корта", "Код корта");
            tableMapping.ColumnMappings.Add("Название корта", "Название корта");
            tableMapping.ColumnMappings.Add("Расположение корта", "Расположение корта");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM `Справочник кортов` WHERE ((`Код корта` = ?) AND ((? = 1 AND `Названи" +
                "е корта` IS NULL) OR (`Название корта` = ?)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_корта", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код корта", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Название_корта", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название корта", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Название_корта", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название корта", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `Справочник кортов` (`Название корта`, `Расположение корта`) VALUES (" +
                "?, ?)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Название_корта", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название корта", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Расположение_корта", global::System.Data.OleDb.OleDbType.LongVarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Расположение корта", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = "UPDATE `Справочник кортов` SET `Название корта` = ?, `Расположение корта` = ? WHE" +
                "RE ((`Код корта` = ?) AND ((? = 1 AND `Название корта` IS NULL) OR (`Название ко" +
                "рта` = ?)))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Название_корта", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название корта", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Расположение_корта", global::System.Data.OleDb.OleDbType.LongVarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Расположение корта", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_корта", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код корта", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Название_корта", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название корта", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Название_корта", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название корта", global::System.Data.DataRowVersion.Original, false, null));
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitConnection()
        {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::kp2_2.Properties.Settings.Default.kp2ConnectionString;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT [Код корта], [Название корта], [Расположение корта] FROM [Справочник корто" +
                "в]";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(кп2_DataSet.Справочник_кортовDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual кп2_DataSet.Справочник_кортовDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            кп2_DataSet.Справочник_кортовDataTable dataTable = new кп2_DataSet.Справочник_кортовDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet.Справочник_кортовDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "Справочник кортов");
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow)
        {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_Код_корта, string Original_Название_корта)
        {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_Код_корта));
            if ((Original_Название_корта == null))
            {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((string)(Original_Название_корта));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string Название_корта, string Расположение_корта)
        {
            if ((Название_корта == null))
            {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(Название_корта));
            }
            if ((Расположение_корта == null))
            {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(Расположение_корта));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string Название_корта, string Расположение_корта, int Original_Код_корта, string Original_Название_корта)
        {
            if ((Название_корта == null))
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(Название_корта));
            }
            if ((Расположение_корта == null))
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(Расположение_корта));
            }
            this.Adapter.UpdateCommand.Parameters[2].Value = ((int)(Original_Код_корта));
            if ((Original_Название_корта == null))
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[4].Value = ((string)(Original_Название_корта));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }

    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class Справочник_систем_проведенияTableAdapter : global::System.ComponentModel.Component
    {

        private global::System.Data.OleDb.OleDbDataAdapter _adapter;

        private global::System.Data.OleDb.OleDbConnection _connection;

        private global::System.Data.OleDb.OleDbTransaction _transaction;

        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;

        private bool _clearBeforeFill;


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public Справочник_систем_проведенияTableAdapter()
        {
            this.ClearBeforeFill = true;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter
        {
            get
            {
                if ((this._adapter == null))
                {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection
        {
            get
            {
                if ((this._connection == null))
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    if ((this.CommandCollection[i] != null))
                    {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.DeleteCommand != null)))
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.InsertCommand != null)))
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.UpdateCommand != null)))
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public bool ClearBeforeFill
        {
            get
            {
                return this._clearBeforeFill;
            }
            set
            {
                this._clearBeforeFill = value;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Справочник систем проведения";
            tableMapping.ColumnMappings.Add("Код системы", "Код системы");
            tableMapping.ColumnMappings.Add("Название системы", "Название системы");
            tableMapping.ColumnMappings.Add("Описание системы", "Описание системы");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM `Справочник систем проведения` WHERE ((`Код системы` = ?) AND ((? = 1" +
                " AND `Название системы` IS NULL) OR (`Название системы` = ?)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_системы", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код системы", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Название_системы", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название системы", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Название_системы", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название системы", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `Справочник систем проведения` (`Название системы`, `Описание системы" +
                "`) VALUES (?, ?)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Название_системы", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название системы", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Описание_системы", global::System.Data.OleDb.OleDbType.LongVarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Описание системы", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = "UPDATE `Справочник систем проведения` SET `Название системы` = ?, `Описание систе" +
                "мы` = ? WHERE ((`Код системы` = ?) AND ((? = 1 AND `Название системы` IS NULL) O" +
                "R (`Название системы` = ?)))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Название_системы", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название системы", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Описание_системы", global::System.Data.OleDb.OleDbType.LongVarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Описание системы", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_системы", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код системы", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Название_системы", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название системы", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Название_системы", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название системы", global::System.Data.DataRowVersion.Original, false, null));
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitConnection()
        {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::kp2_2.Properties.Settings.Default.kp2ConnectionString;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT [Код системы], [Название системы], [Описание системы] FROM [Справочник сис" +
                "тем проведения]";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(кп2_DataSet.Справочник_систем_проведенияDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual кп2_DataSet.Справочник_систем_проведенияDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            кп2_DataSet.Справочник_систем_проведенияDataTable dataTable = new кп2_DataSet.Справочник_систем_проведенияDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet.Справочник_систем_проведенияDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "Справочник систем проведения");
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow)
        {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_Код_системы, string Original_Название_системы)
        {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_Код_системы));
            if ((Original_Название_системы == null))
            {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((string)(Original_Название_системы));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string Название_системы, string Описание_системы)
        {
            if ((Название_системы == null))
            {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(Название_системы));
            }
            if ((Описание_системы == null))
            {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(Описание_системы));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string Название_системы, string Описание_системы, int Original_Код_системы, string Original_Название_системы)
        {
            if ((Название_системы == null))
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(Название_системы));
            }
            if ((Описание_системы == null))
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(Описание_системы));
            }
            this.Adapter.UpdateCommand.Parameters[2].Value = ((int)(Original_Код_системы));
            if ((Original_Название_системы == null))
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[4].Value = ((string)(Original_Название_системы));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }

    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class Справочник_этапов_турнираTableAdapter : global::System.ComponentModel.Component
    {

        private global::System.Data.OleDb.OleDbDataAdapter _adapter;

        private global::System.Data.OleDb.OleDbConnection _connection;

        private global::System.Data.OleDb.OleDbTransaction _transaction;

        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;

        private bool _clearBeforeFill;


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public Справочник_этапов_турнираTableAdapter()
        {
            this.ClearBeforeFill = true;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter
        {
            get
            {
                if ((this._adapter == null))
                {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection
        {
            get
            {
                if ((this._connection == null))
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    if ((this.CommandCollection[i] != null))
                    {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.DeleteCommand != null)))
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.InsertCommand != null)))
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.UpdateCommand != null)))
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public bool ClearBeforeFill
        {
            get
            {
                return this._clearBeforeFill;
            }
            set
            {
                this._clearBeforeFill = value;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Справочник этапов турнира";
            tableMapping.ColumnMappings.Add("Код этапа", "Код этапа");
            tableMapping.ColumnMappings.Add("Этап", "Этап");
            tableMapping.ColumnMappings.Add("Код системы проведения", "Код системы проведения");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM `Справочник этапов турнира` WHERE ((`Код этапа` = ?) AND ((? = 1 AND " +
                "`Этап` IS NULL) OR (`Этап` = ?)) AND ((? = 1 AND `Код системы проведения` IS NUL" +
                "L) OR (`Код системы проведения` = ?)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_этапа", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код этапа", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Этап", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Этап", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Этап", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Этап", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Код_системы_проведения", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код системы проведения", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_системы_проведения", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код системы проведения", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `Справочник этапов турнира` (`Этап`, `Код системы проведения`) VALUES" +
                " (?, ?)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Этап", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Этап", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Код_системы_проведения", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код системы проведения", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = "UPDATE `Справочник этапов турнира` SET `Этап` = ?, `Код системы проведения` = ? W" +
                "HERE ((`Код этапа` = ?) AND ((? = 1 AND `Этап` IS NULL) OR (`Этап` = ?)) AND ((?" +
                " = 1 AND `Код системы проведения` IS NULL) OR (`Код системы проведения` = ?)))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Этап", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Этап", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Код_системы_проведения", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код системы проведения", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_этапа", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код этапа", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Этап", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Этап", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Этап", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Этап", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Код_системы_проведения", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код системы проведения", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код_системы_проведения", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код системы проведения", global::System.Data.DataRowVersion.Original, false, null));
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitConnection()
        {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::kp2_2.Properties.Settings.Default.kp2ConnectionString;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT [Код этапа], Этап, [Код системы проведения] FROM [Справочник этапов турнир" +
                "а]";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(кп2_DataSet.Справочник_этапов_турнираDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual кп2_DataSet.Справочник_этапов_турнираDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            кп2_DataSet.Справочник_этапов_турнираDataTable dataTable = new кп2_DataSet.Справочник_этапов_турнираDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet.Справочник_этапов_турнираDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "Справочник этапов турнира");
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow)
        {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_Код_этапа, string Original_Этап, global::System.Nullable<int> Original_Код_системы_проведения)
        {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_Код_этапа));
            if ((Original_Этап == null))
            {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((string)(Original_Этап));
            }
            if ((Original_Код_системы_проведения.HasValue == true))
            {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((int)(Original_Код_системы_проведения.Value));
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string Этап, global::System.Nullable<int> Код_системы_проведения)
        {
            if ((Этап == null))
            {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(Этап));
            }
            if ((Код_системы_проведения.HasValue == true))
            {
                this.Adapter.InsertCommand.Parameters[1].Value = ((int)(Код_системы_проведения.Value));
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string Этап, global::System.Nullable<int> Код_системы_проведения, int Original_Код_этапа, string Original_Этап, global::System.Nullable<int> Original_Код_системы_проведения)
        {
            if ((Этап == null))
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(Этап));
            }
            if ((Код_системы_проведения.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((int)(Код_системы_проведения.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[2].Value = ((int)(Original_Код_этапа));
            if ((Original_Этап == null))
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[4].Value = ((string)(Original_Этап));
            }
            if ((Original_Код_системы_проведения.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[6].Value = ((int)(Original_Код_системы_проведения.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }

    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class ТурнирыTableAdapter : global::System.ComponentModel.Component
    {

        private global::System.Data.OleDb.OleDbDataAdapter _adapter;

        private global::System.Data.OleDb.OleDbConnection _connection;

        private global::System.Data.OleDb.OleDbTransaction _transaction;

        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;

        private bool _clearBeforeFill;


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public ТурнирыTableAdapter()
        {
            this.ClearBeforeFill = true;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter
        {
            get
            {
                if ((this._adapter == null))
                {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection
        {
            get
            {
                if ((this._connection == null))
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    if ((this.CommandCollection[i] != null))
                    {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.DeleteCommand != null)))
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.InsertCommand != null)))
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.UpdateCommand != null)))
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public bool ClearBeforeFill
        {
            get
            {
                return this._clearBeforeFill;
            }
            set
            {
                this._clearBeforeFill = value;
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Турниры";
            tableMapping.ColumnMappings.Add("Код турнира", "Код турнира");
            tableMapping.ColumnMappings.Add("Наименование", "Наименование");
            tableMapping.ColumnMappings.Add("Код категории", "Код категории");
            tableMapping.ColumnMappings.Add("Код системы проведения", "Код системы проведения");
            tableMapping.ColumnMappings.Add("Количество участников", "Количество участников");
            tableMapping.ColumnMappings.Add("Разряд", "Разряд");
            tableMapping.ColumnMappings.Add("Количество групп", "Количество групп");
            tableMapping.ColumnMappings.Add("Дата начала", "Дата начала");
            tableMapping.ColumnMappings.Add("Дата конца", "Дата конца");
            tableMapping.ColumnMappings.Add("Количество кортов", "Количество кортов");
            tableMapping.ColumnMappings.Add("Код корта 1", "Код корта 1");
            tableMapping.ColumnMappings.Add("Код корта 2", "Код корта 2");
            tableMapping.ColumnMappings.Add("Код корта 3", "Код корта 3");
            tableMapping.ColumnMappings.Add("Время начала проведения", "Время начала проведения");
            tableMapping.ColumnMappings.Add("Время конца проведения", "Время конца проведения");
            tableMapping.ColumnMappings.Add("Длительность матча", "Длительность матча");
            tableMapping.ColumnMappings.Add("ФИО директора", "ФИО директора");
            tableMapping.ColumnMappings.Add("Телефон директора", "Телефон директора");
            tableMapping.ColumnMappings.Add("Количество сеянных участников", "Количество сеянных участников");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitConnection()
        {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::kp2_2.Properties.Settings.Default.kp2ConnectionString;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = @"SELECT [Код турнира], Наименование, [Код категории], [Код системы проведения], [Количество участников], Разряд, [Количество групп], [Дата начала], [Дата конца], [Количество кортов], [Код корта 1], [Код корта 2], [Код корта 3], [Время начала проведения], [Время конца проведения], [Длительность матча], [ФИО директора], [Телефон директора], [Количество сеянных участников] FROM Турниры ORDER BY [Код турнира]";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(кп2_DataSet.ТурнирыDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual кп2_DataSet.ТурнирыDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            кп2_DataSet.ТурнирыDataTable dataTable = new кп2_DataSet.ТурнирыDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet.ТурнирыDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(кп2_DataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "Турниры");
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow)
        {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(string code)
        {
            this._adapter.DeleteCommand.CommandText = "DELETE FROM [Турниры] WHERE [Код турнира] = " + code;
            global::System.Data.ConnectionState previousConnectionState = this._adapter.DeleteCommand.Connection.State;
            if (((this._adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this._adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                int returnValue = this._adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this._adapter.DeleteCommand.Connection.Close();
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.Table_adapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string newelement)
        {
            this._adapter.InsertCommand.CommandText = "INSERT INTO [Турниры] VALUES (" + newelement + ")";
            global::System.Data.ConnectionState previousConnectionState = this._adapter.InsertCommand.Connection.State;
            if (((this._adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) != global::System.Data.ConnectionState.Open))
            {
                this._adapter.InsertCommand.Connection.Open();
            }
            try
            {
                int returnValue = this._adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this._adapter.InsertCommand.Connection.Close();
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.Table_adapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string newelement, string code)
        {
            this._adapter.UpdateCommand.CommandText = "UPDATE [Турниры] SET " + newelement + " WHERE [Код турнира] = " + code;
            global::System.Data.ConnectionState previousConnectionState = this._adapter.UpdateCommand.Connection.State;
            if (((this._adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this._adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                int returnValue = this._adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this._adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }

    /// <summary>
    ///TableAdapterManager is used to coordinate TableAdapters in the dataset to enable Hierarchical Update scenarios
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSD" +
    "esigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapterManager")]
    public partial class TableAdapterManager : global::System.ComponentModel.Component
        {

            private UpdateOrderOption _updateOrder;

            private РасписаниеTableAdapter _расписаниеTableAdapter;

            private СеткиTableAdapter _сеткиTableAdapter;

            private Списки_участниковTableAdapter _списки_участниковTableAdapter;

            private Справочник_игроковTableAdapter _справочник_игроковTableAdapter;

            private Справочник_катерогийTableAdapter _справочник_катерогийTableAdapter;

            private Справочник_кортовTableAdapter _справочник_кортовTableAdapter;

            private Справочник_систем_проведенияTableAdapter _справочник_систем_проведенияTableAdapter;

            private Справочник_этапов_турнираTableAdapter _справочник_этапов_турнираTableAdapter;

            private ТурнирыTableAdapter _турнирыTableAdapter;

            private bool _backupDataSetBeforeUpdate;

            private global::System.Data.IDbConnection _connection;


            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public UpdateOrderOption UpdateOrder
            {
                get
                {
                    return this._updateOrder;
                }
                set
                {
                    this._updateOrder = value;
                }
            }


            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
                "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                "a", "System.Drawing.Design.UITypeEditor")]
            public РасписаниеTableAdapter РасписаниеTableAdapter
            {
                get
                {
                    return this._расписаниеTableAdapter;
                }
                set
                {
                    this._расписаниеTableAdapter = value;
                }
            }


            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
                "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                "a", "System.Drawing.Design.UITypeEditor")]
            public СеткиTableAdapter СеткиTableAdapter
            {
                get
                {
                    return this._сеткиTableAdapter;
                }
                set
                {
                    this._сеткиTableAdapter = value;
                }
            }


            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
                "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                "a", "System.Drawing.Design.UITypeEditor")]
            public Списки_участниковTableAdapter Списки_участниковTableAdapter
            {
                get
                {
                    return this._списки_участниковTableAdapter;
                }
                set
                {
                    this._списки_участниковTableAdapter = value;
                }
            }


            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
                "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                "a", "System.Drawing.Design.UITypeEditor")]
            public Справочник_игроковTableAdapter Справочник_игроковTableAdapter
            {
                get
                {
                    return this._справочник_игроковTableAdapter;
                }
                set
                {
                    this._справочник_игроковTableAdapter = value;
                }
            }


            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
                "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                "a", "System.Drawing.Design.UITypeEditor")]
            public Справочник_катерогийTableAdapter Справочник_катерогийTableAdapter
            {
                get
                {
                    return this._справочник_катерогийTableAdapter;
                }
                set
                {
                    this._справочник_катерогийTableAdapter = value;
                }
            }


            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
                "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                "a", "System.Drawing.Design.UITypeEditor")]
            public Справочник_кортовTableAdapter Справочник_кортовTableAdapter
            {
                get
                {
                    return this._справочник_кортовTableAdapter;
                }
                set
                {
                    this._справочник_кортовTableAdapter = value;
                }
            }


            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
                "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                "a", "System.Drawing.Design.UITypeEditor")]
            public Справочник_систем_проведенияTableAdapter Справочник_систем_проведенияTableAdapter
            {
                get
                {
                    return this._справочник_систем_проведенияTableAdapter;
                }
                set
                {
                    this._справочник_систем_проведенияTableAdapter = value;
                }
            }


            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
                "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                "a", "System.Drawing.Design.UITypeEditor")]
            public Справочник_этапов_турнираTableAdapter Справочник_этапов_турнираTableAdapter
            {
                get
                {
                    return this._справочник_этапов_турнираTableAdapter;
                }
                set
                {
                    this._справочник_этапов_турнираTableAdapter = value;
                }
            }


            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
                "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                "a", "System.Drawing.Design.UITypeEditor")]
            public ТурнирыTableAdapter ТурнирыTableAdapter
            {
                get
                {
                    return this._турнирыTableAdapter;
                }
                set
                {
                    this._турнирыTableAdapter = value;
                }
            }


            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool BackupDataSetBeforeUpdate
            {
                get
                {
                    return this._backupDataSetBeforeUpdate;
                }
                set
                {
                    this._backupDataSetBeforeUpdate = value;
                }
            }


            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public global::System.Data.IDbConnection Connection
            {
                get
                {
                    if ((this._connection != null))
                    {
                        return this._connection;
                    }
                    if (((this._расписаниеTableAdapter != null)
                                && (this._расписаниеTableAdapter.Connection != null)))
                    {
                        return this._расписаниеTableAdapter.Connection;
                    }
                    if (((this._сеткиTableAdapter != null)
                                && (this._сеткиTableAdapter.Connection != null)))
                    {
                        return this._сеткиTableAdapter.Connection;
                    }
                    if (((this._списки_участниковTableAdapter != null)
                                && (this._списки_участниковTableAdapter.Connection != null)))
                    {
                        return this._списки_участниковTableAdapter.Connection;
                    }
                    if (((this._справочник_игроковTableAdapter != null)
                                && (this._справочник_игроковTableAdapter.Connection != null)))
                    {
                        return this._справочник_игроковTableAdapter.Connection;
                    }
                    if (((this._справочник_катерогийTableAdapter != null)
                                && (this._справочник_катерогийTableAdapter.Connection != null)))
                    {
                        return this._справочник_катерогийTableAdapter.Connection;
                    }
                    if (((this._справочник_кортовTableAdapter != null)
                                && (this._справочник_кортовTableAdapter.Connection != null)))
                    {
                        return this._справочник_кортовTableAdapter.Connection;
                    }
                    if (((this._справочник_систем_проведенияTableAdapter != null)
                                && (this._справочник_систем_проведенияTableAdapter.Connection != null)))
                    {
                        return this._справочник_систем_проведенияTableAdapter.Connection;
                    }
                    if (((this._справочник_этапов_турнираTableAdapter != null)
                                && (this._справочник_этапов_турнираTableAdapter.Connection != null)))
                    {
                        return this._справочник_этапов_турнираTableAdapter.Connection;
                    }
                    if (((this._турнирыTableAdapter != null)
                                && (this._турнирыTableAdapter.Connection != null)))
                    {
                        return this._турнирыTableAdapter.Connection;
                    }
                    return null;
                }
                set
                {
                    this._connection = value;
                }
            }


            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int TableAdapterInstanceCount
            {
                get
                {
                    int count = 0;
                    if ((this._расписаниеTableAdapter != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._сеткиTableAdapter != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._списки_участниковTableAdapter != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._справочник_игроковTableAdapter != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._справочник_катерогийTableAdapter != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._справочник_кортовTableAdapter != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._справочник_систем_проведенияTableAdapter != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._справочник_этапов_турнираTableAdapter != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._турнирыTableAdapter != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }

            /// <summary>
            ///Update rows in top-down order.
            ///</summary>

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private int UpdateUpdatedRows(кп2_DataSet dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows)
            {
                int result = 0;
                if ((this._справочник_катерогийTableAdapter != null))
                {
                    global::System.Data.DataRow[] updatedRows = dataSet.Справочник_катерогий.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                    updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                    if (((updatedRows != null)
                                && (0 < updatedRows.Length)))
                    {
                        result = (result + this._справочник_катерогийTableAdapter.Update(updatedRows));
                        allChangedRows.AddRange(updatedRows);
                    }
                }
                if ((this._справочник_кортовTableAdapter != null))
                {
                    global::System.Data.DataRow[] updatedRows = dataSet.Справочник_кортов.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                    updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                    if (((updatedRows != null)
                                && (0 < updatedRows.Length)))
                    {
                        result = (result + this._справочник_кортовTableAdapter.Update(updatedRows));
                        allChangedRows.AddRange(updatedRows);
                    }
                }
                if ((this._справочник_систем_проведенияTableAdapter != null))
                {
                    global::System.Data.DataRow[] updatedRows = dataSet.Справочник_систем_проведения.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                    updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                    if (((updatedRows != null)
                                && (0 < updatedRows.Length)))
                    {
                        result = (result + this._справочник_систем_проведенияTableAdapter.Update(updatedRows));
                        allChangedRows.AddRange(updatedRows);
                    }
                }
                if ((this._справочник_этапов_турнираTableAdapter != null))
                {
                    global::System.Data.DataRow[] updatedRows = dataSet.Справочник_этапов_турнира.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                    updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                    if (((updatedRows != null)
                                && (0 < updatedRows.Length)))
                    {
                        result = (result + this._справочник_этапов_турнираTableAdapter.Update(updatedRows));
                        allChangedRows.AddRange(updatedRows);
                    }
                }
                if ((this._турнирыTableAdapter != null))
                {
                    global::System.Data.DataRow[] updatedRows = dataSet.Турниры.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                    updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                    if (((updatedRows != null)
                                && (0 < updatedRows.Length)))
                    {
                        result = (result + this._турнирыTableAdapter.Update(updatedRows));
                        allChangedRows.AddRange(updatedRows);
                    }
                }
                if ((this._сеткиTableAdapter != null))
                {
                    global::System.Data.DataRow[] updatedRows = dataSet.Сетки.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                    updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                    if (((updatedRows != null)
                                && (0 < updatedRows.Length)))
                    {
                        result = (result + this._сеткиTableAdapter.Update(updatedRows));
                        allChangedRows.AddRange(updatedRows);
                    }
                }
                if ((this._справочник_игроковTableAdapter != null))
                {
                    global::System.Data.DataRow[] updatedRows = dataSet.Справочник_игроков.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                    updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                    if (((updatedRows != null)
                                && (0 < updatedRows.Length)))
                    {
                        result = (result + this._справочник_игроковTableAdapter.Update(updatedRows));
                        allChangedRows.AddRange(updatedRows);
                    }
                }
                if ((this._расписаниеTableAdapter != null))
                {
                    global::System.Data.DataRow[] updatedRows = dataSet.Расписание.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                    updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                    if (((updatedRows != null)
                                && (0 < updatedRows.Length)))
                    {
                        result = (result + this._расписаниеTableAdapter.Update(updatedRows));
                        allChangedRows.AddRange(updatedRows);
                    }
                }
                if ((this._списки_участниковTableAdapter != null))
                {
                    global::System.Data.DataRow[] updatedRows = dataSet.Списки_участников.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                    updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                    if (((updatedRows != null)
                                && (0 < updatedRows.Length)))
                    {
                        result = (result + this._списки_участниковTableAdapter.Update(updatedRows));
                        allChangedRows.AddRange(updatedRows);
                    }
                }
                return result;
            }

            /// <summary>
            ///Insert rows in top-down order.
            ///</summary>

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private int UpdateInsertedRows(кп2_DataSet dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows)
            {
                int result = 0;
                if ((this._справочник_катерогийTableAdapter != null))
                {
                    global::System.Data.DataRow[] addedRows = dataSet.Справочник_катерогий.Select(null, null, global::System.Data.DataViewRowState.Added);
                    if (((addedRows != null)
                                && (0 < addedRows.Length)))
                    {
                        result = (result + this._справочник_катерогийTableAdapter.Update(addedRows));
                        allAddedRows.AddRange(addedRows);
                    }
                }
                if ((this._справочник_кортовTableAdapter != null))
                {
                    global::System.Data.DataRow[] addedRows = dataSet.Справочник_кортов.Select(null, null, global::System.Data.DataViewRowState.Added);
                    if (((addedRows != null)
                                && (0 < addedRows.Length)))
                    {
                        result = (result + this._справочник_кортовTableAdapter.Update(addedRows));
                        allAddedRows.AddRange(addedRows);
                    }
                }
                if ((this._справочник_систем_проведенияTableAdapter != null))
                {
                    global::System.Data.DataRow[] addedRows = dataSet.Справочник_систем_проведения.Select(null, null, global::System.Data.DataViewRowState.Added);
                    if (((addedRows != null)
                                && (0 < addedRows.Length)))
                    {
                        result = (result + this._справочник_систем_проведенияTableAdapter.Update(addedRows));
                        allAddedRows.AddRange(addedRows);
                    }
                }
                if ((this._справочник_этапов_турнираTableAdapter != null))
                {
                    global::System.Data.DataRow[] addedRows = dataSet.Справочник_этапов_турнира.Select(null, null, global::System.Data.DataViewRowState.Added);
                    if (((addedRows != null)
                                && (0 < addedRows.Length)))
                    {
                        result = (result + this._справочник_этапов_турнираTableAdapter.Update(addedRows));
                        allAddedRows.AddRange(addedRows);
                    }
                }
                if ((this._турнирыTableAdapter != null))
                {
                    global::System.Data.DataRow[] addedRows = dataSet.Турниры.Select(null, null, global::System.Data.DataViewRowState.Added);
                    if (((addedRows != null)
                                && (0 < addedRows.Length)))
                    {
                        result = (result + this._турнирыTableAdapter.Update(addedRows));
                        allAddedRows.AddRange(addedRows);
                    }
                }
                if ((this._сеткиTableAdapter != null))
                {
                    global::System.Data.DataRow[] addedRows = dataSet.Сетки.Select(null, null, global::System.Data.DataViewRowState.Added);
                    if (((addedRows != null)
                                && (0 < addedRows.Length)))
                    {
                        result = (result + this._сеткиTableAdapter.Update(addedRows));
                        allAddedRows.AddRange(addedRows);
                    }
                }
                if ((this._справочник_игроковTableAdapter != null))
                {
                    global::System.Data.DataRow[] addedRows = dataSet.Справочник_игроков.Select(null, null, global::System.Data.DataViewRowState.Added);
                    if (((addedRows != null)
                                && (0 < addedRows.Length)))
                    {
                        result = (result + this._справочник_игроковTableAdapter.Update(addedRows));
                        allAddedRows.AddRange(addedRows);
                    }
                }
                if ((this._расписаниеTableAdapter != null))
                {
                    global::System.Data.DataRow[] addedRows = dataSet.Расписание.Select(null, null, global::System.Data.DataViewRowState.Added);
                    if (((addedRows != null)
                                && (0 < addedRows.Length)))
                    {
                        result = (result + this._расписаниеTableAdapter.Update(addedRows));
                        allAddedRows.AddRange(addedRows);
                    }
                }
                if ((this._списки_участниковTableAdapter != null))
                {
                    global::System.Data.DataRow[] addedRows = dataSet.Списки_участников.Select(null, null, global::System.Data.DataViewRowState.Added);
                    if (((addedRows != null)
                                && (0 < addedRows.Length)))
                    {
                        result = (result + this._списки_участниковTableAdapter.Update(addedRows));
                        allAddedRows.AddRange(addedRows);
                    }
                }
                return result;
            }

            /// <summary>
            ///Delete rows in bottom-up order.
            ///</summary>

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private int UpdateDeletedRows(кп2_DataSet dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows)
            {
                int result = 0;
                if ((this._списки_участниковTableAdapter != null))
                {
                    global::System.Data.DataRow[] deletedRows = dataSet.Списки_участников.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                    if (((deletedRows != null)
                                && (0 < deletedRows.Length)))
                    {
                        result = (result + this._списки_участниковTableAdapter.Update(deletedRows));
                        allChangedRows.AddRange(deletedRows);
                    }
                }
                if ((this._расписаниеTableAdapter != null))
                {
                    global::System.Data.DataRow[] deletedRows = dataSet.Расписание.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                    if (((deletedRows != null)
                                && (0 < deletedRows.Length)))
                    {
                        result = (result + this._расписаниеTableAdapter.Update(deletedRows));
                        allChangedRows.AddRange(deletedRows);
                    }
                }
                if ((this._справочник_игроковTableAdapter != null))
                {
                    global::System.Data.DataRow[] deletedRows = dataSet.Справочник_игроков.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                    if (((deletedRows != null)
                                && (0 < deletedRows.Length)))
                    {
                        result = (result + this._справочник_игроковTableAdapter.Update(deletedRows));
                        allChangedRows.AddRange(deletedRows);
                    }
                }
                if ((this._сеткиTableAdapter != null))
                {
                    global::System.Data.DataRow[] deletedRows = dataSet.Сетки.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                    if (((deletedRows != null)
                                && (0 < deletedRows.Length)))
                    {
                        result = (result + this._сеткиTableAdapter.Update(deletedRows));
                        allChangedRows.AddRange(deletedRows);
                    }
                }
                if ((this._турнирыTableAdapter != null))
                {
                    global::System.Data.DataRow[] deletedRows = dataSet.Турниры.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                    if (((deletedRows != null)
                                && (0 < deletedRows.Length)))
                    {
                        result = (result + this._турнирыTableAdapter.Update(deletedRows));
                        allChangedRows.AddRange(deletedRows);
                    }
                }
                if ((this._справочник_этапов_турнираTableAdapter != null))
                {
                    global::System.Data.DataRow[] deletedRows = dataSet.Справочник_этапов_турнира.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                    if (((deletedRows != null)
                                && (0 < deletedRows.Length)))
                    {
                        result = (result + this._справочник_этапов_турнираTableAdapter.Update(deletedRows));
                        allChangedRows.AddRange(deletedRows);
                    }
                }
                if ((this._справочник_систем_проведенияTableAdapter != null))
                {
                    global::System.Data.DataRow[] deletedRows = dataSet.Справочник_систем_проведения.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                    if (((deletedRows != null)
                                && (0 < deletedRows.Length)))
                    {
                        result = (result + this._справочник_систем_проведенияTableAdapter.Update(deletedRows));
                        allChangedRows.AddRange(deletedRows);
                    }
                }
                if ((this._справочник_кортовTableAdapter != null))
                {
                    global::System.Data.DataRow[] deletedRows = dataSet.Справочник_кортов.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                    if (((deletedRows != null)
                                && (0 < deletedRows.Length)))
                    {
                        result = (result + this._справочник_кортовTableAdapter.Update(deletedRows));
                        allChangedRows.AddRange(deletedRows);
                    }
                }
                if ((this._справочник_катерогийTableAdapter != null))
                {
                    global::System.Data.DataRow[] deletedRows = dataSet.Справочник_катерогий.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                    if (((deletedRows != null)
                                && (0 < deletedRows.Length)))
                    {
                        result = (result + this._справочник_катерогийTableAdapter.Update(deletedRows));
                        allChangedRows.AddRange(deletedRows);
                    }
                }
                return result;
            }

            /// <summary>
            ///Remove inserted rows that become updated rows after calling TableAdapter.Update(inserted rows) first
            ///</summary>

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private global::System.Data.DataRow[] GetRealUpdatedRows(global::System.Data.DataRow[] updatedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows)
            {
                if (((updatedRows == null)
                            || (updatedRows.Length < 1)))
                {
                    return updatedRows;
                }
                if (((allAddedRows == null)
                            || (allAddedRows.Count < 1)))
                {
                    return updatedRows;
                }
                global::System.Collections.Generic.List<global::System.Data.DataRow> realUpdatedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
                for (int i = 0; (i < updatedRows.Length); i = (i + 1))
                {
                    global::System.Data.DataRow row = updatedRows[i];
                    if ((allAddedRows.Contains(row) == false))
                    {
                        realUpdatedRows.Add(row);
                    }
                }
                return realUpdatedRows.ToArray();
            }

            /// <summary>
            ///Update all changes to the dataset.
            ///</summary>

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public virtual int UpdateAll(кп2_DataSet dataSet)
            {
                if ((dataSet == null))
                {
                    throw new global::System.ArgumentNullException("dataSet");
                }
                if ((dataSet.HasChanges() == false))
                {
                    return 0;
                }
                if (((this._расписаниеTableAdapter != null)
                            && (this.MatchTableAdapterConnection(this._расписаниеTableAdapter.Connection) == false)))
                {
                    throw new global::System.ArgumentException("Все адаптеры таблицы, управляемые диспетчером адаптера таблицы TableAdapterManage" +
                            "r, должны использовать одинаковую строку подключения.");
                }
                if (((this._сеткиTableAdapter != null)
                            && (this.MatchTableAdapterConnection(this._сеткиTableAdapter.Connection) == false)))
                {
                    throw new global::System.ArgumentException("Все адаптеры таблицы, управляемые диспетчером адаптера таблицы TableAdapterManage" +
                            "r, должны использовать одинаковую строку подключения.");
                }
                if (((this._списки_участниковTableAdapter != null)
                            && (this.MatchTableAdapterConnection(this._списки_участниковTableAdapter.Connection) == false)))
                {
                    throw new global::System.ArgumentException("Все адаптеры таблицы, управляемые диспетчером адаптера таблицы TableAdapterManage" +
                            "r, должны использовать одинаковую строку подключения.");
                }
                if (((this._справочник_игроковTableAdapter != null)
                            && (this.MatchTableAdapterConnection(this._справочник_игроковTableAdapter.Connection) == false)))
                {
                    throw new global::System.ArgumentException("Все адаптеры таблицы, управляемые диспетчером адаптера таблицы TableAdapterManage" +
                            "r, должны использовать одинаковую строку подключения.");
                }
                if (((this._справочник_катерогийTableAdapter != null)
                            && (this.MatchTableAdapterConnection(this._справочник_катерогийTableAdapter.Connection) == false)))
                {
                    throw new global::System.ArgumentException("Все адаптеры таблицы, управляемые диспетчером адаптера таблицы TableAdapterManage" +
                            "r, должны использовать одинаковую строку подключения.");
                }
                if (((this._справочник_кортовTableAdapter != null)
                            && (this.MatchTableAdapterConnection(this._справочник_кортовTableAdapter.Connection) == false)))
                {
                    throw new global::System.ArgumentException("Все адаптеры таблицы, управляемые диспетчером адаптера таблицы TableAdapterManage" +
                            "r, должны использовать одинаковую строку подключения.");
                }
                if (((this._справочник_систем_проведенияTableAdapter != null)
                            && (this.MatchTableAdapterConnection(this._справочник_систем_проведенияTableAdapter.Connection) == false)))
                {
                    throw new global::System.ArgumentException("Все адаптеры таблицы, управляемые диспетчером адаптера таблицы TableAdapterManage" +
                            "r, должны использовать одинаковую строку подключения.");
                }
                if (((this._справочник_этапов_турнираTableAdapter != null)
                            && (this.MatchTableAdapterConnection(this._справочник_этапов_турнираTableAdapter.Connection) == false)))
                {
                    throw new global::System.ArgumentException("Все адаптеры таблицы, управляемые диспетчером адаптера таблицы TableAdapterManage" +
                            "r, должны использовать одинаковую строку подключения.");
                }
                if (((this._турнирыTableAdapter != null)
                            && (this.MatchTableAdapterConnection(this._турнирыTableAdapter.Connection) == false)))
                {
                    throw new global::System.ArgumentException("Все адаптеры таблицы, управляемые диспетчером адаптера таблицы TableAdapterManage" +
                            "r, должны использовать одинаковую строку подключения.");
                }
                global::System.Data.IDbConnection workConnection = this.Connection;
                if ((workConnection == null))
                {
                    throw new global::System.ApplicationException("TableAdapterManager не содержит сведений о подключении. Укажите для каждого адапт" +
                            "ера таблицы TableAdapterManager допустимый экземпляр адаптера таблицы.");
                }
                bool workConnOpened = false;
                if (((workConnection.State & global::System.Data.ConnectionState.Broken)
                            == global::System.Data.ConnectionState.Broken))
                {
                    workConnection.Close();
                }
                if ((workConnection.State == global::System.Data.ConnectionState.Closed))
                {
                    workConnection.Open();
                    workConnOpened = true;
                }
                global::System.Data.IDbTransaction workTransaction = workConnection.BeginTransaction();
                if ((workTransaction == null))
                {
                    throw new global::System.ApplicationException("Не удается начать транзакцию. Текущее соединение данных не поддерживает транзакци" +
                            "и или текущее состояние не позволяет начать транзакцию.");
                }
                global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
                global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
                global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter> adaptersWithAcceptChangesDuringUpdate = new global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter>();
                global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection> revertConnections = new global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection>();
                int result = 0;
                global::System.Data.DataSet backupDataSet = null;
                if (this.BackupDataSetBeforeUpdate)
                {
                    backupDataSet = new global::System.Data.DataSet();
                    backupDataSet.Merge(dataSet);
                }
                try
                {
                    // ---- Prepare for update -----------
                    //
                    if ((this._расписаниеTableAdapter != null))
                    {
                        revertConnections.Add(this._расписаниеTableAdapter, this._расписаниеTableAdapter.Connection);
                        this._расписаниеTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                        this._расписаниеTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                        if (this._расписаниеTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._расписаниеTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            adaptersWithAcceptChangesDuringUpdate.Add(this._расписаниеTableAdapter.Adapter);
                        }
                    }
                    if ((this._сеткиTableAdapter != null))
                    {
                        revertConnections.Add(this._сеткиTableAdapter, this._сеткиTableAdapter.Connection);
                        this._сеткиTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                        this._сеткиTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                        if (this._сеткиTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._сеткиTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            adaptersWithAcceptChangesDuringUpdate.Add(this._сеткиTableAdapter.Adapter);
                        }
                    }
                    if ((this._списки_участниковTableAdapter != null))
                    {
                        revertConnections.Add(this._списки_участниковTableAdapter, this._списки_участниковTableAdapter.Connection);
                        this._списки_участниковTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                        this._списки_участниковTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                        if (this._списки_участниковTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._списки_участниковTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            adaptersWithAcceptChangesDuringUpdate.Add(this._списки_участниковTableAdapter.Adapter);
                        }
                    }
                    if ((this._справочник_игроковTableAdapter != null))
                    {
                        revertConnections.Add(this._справочник_игроковTableAdapter, this._справочник_игроковTableAdapter.Connection);
                        this._справочник_игроковTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                        this._справочник_игроковTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                        if (this._справочник_игроковTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._справочник_игроковTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            adaptersWithAcceptChangesDuringUpdate.Add(this._справочник_игроковTableAdapter.Adapter);
                        }
                    }
                    if ((this._справочник_катерогийTableAdapter != null))
                    {
                        revertConnections.Add(this._справочник_катерогийTableAdapter, this._справочник_катерогийTableAdapter.Connection);
                        this._справочник_катерогийTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                        this._справочник_катерогийTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                        if (this._справочник_катерогийTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._справочник_катерогийTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            adaptersWithAcceptChangesDuringUpdate.Add(this._справочник_катерогийTableAdapter.Adapter);
                        }
                    }
                    if ((this._справочник_кортовTableAdapter != null))
                    {
                        revertConnections.Add(this._справочник_кортовTableAdapter, this._справочник_кортовTableAdapter.Connection);
                        this._справочник_кортовTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                        this._справочник_кортовTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                        if (this._справочник_кортовTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._справочник_кортовTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            adaptersWithAcceptChangesDuringUpdate.Add(this._справочник_кортовTableAdapter.Adapter);
                        }
                    }
                    if ((this._справочник_систем_проведенияTableAdapter != null))
                    {
                        revertConnections.Add(this._справочник_систем_проведенияTableAdapter, this._справочник_систем_проведенияTableAdapter.Connection);
                        this._справочник_систем_проведенияTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                        this._справочник_систем_проведенияTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                        if (this._справочник_систем_проведенияTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._справочник_систем_проведенияTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            adaptersWithAcceptChangesDuringUpdate.Add(this._справочник_систем_проведенияTableAdapter.Adapter);
                        }
                    }
                    if ((this._справочник_этапов_турнираTableAdapter != null))
                    {
                        revertConnections.Add(this._справочник_этапов_турнираTableAdapter, this._справочник_этапов_турнираTableAdapter.Connection);
                        this._справочник_этапов_турнираTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                        this._справочник_этапов_турнираTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                        if (this._справочник_этапов_турнираTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._справочник_этапов_турнираTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            adaptersWithAcceptChangesDuringUpdate.Add(this._справочник_этапов_турнираTableAdapter.Adapter);
                        }
                    }
                    if ((this._турнирыTableAdapter != null))
                    {
                        revertConnections.Add(this._турнирыTableAdapter, this._турнирыTableAdapter.Connection);
                        this._турнирыTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                        this._турнирыTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                        if (this._турнирыTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._турнирыTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            adaptersWithAcceptChangesDuringUpdate.Add(this._турнирыTableAdapter.Adapter);
                        }
                    }
                    // 
                    //---- Perform updates -----------
                    //
                    if ((this.UpdateOrder == UpdateOrderOption.UpdateInsertDelete))
                    {
                        result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                        result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                    }
                    else
                    {
                        result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                        result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                    }
                    result = (result + this.UpdateDeletedRows(dataSet, allChangedRows));
                    // 
                    //---- Commit updates -----------
                    //
                    workTransaction.Commit();
                    if ((0 < allAddedRows.Count))
                    {
                        global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                        allAddedRows.CopyTo(rows);
                        for (int i = 0; (i < rows.Length); i = (i + 1))
                        {
                            global::System.Data.DataRow row = rows[i];
                            row.AcceptChanges();
                        }
                    }
                    if ((0 < allChangedRows.Count))
                    {
                        global::System.Data.DataRow[] rows = new System.Data.DataRow[allChangedRows.Count];
                        allChangedRows.CopyTo(rows);
                        for (int i = 0; (i < rows.Length); i = (i + 1))
                        {
                            global::System.Data.DataRow row = rows[i];
                            row.AcceptChanges();
                        }
                    }
                }
                catch (global::System.Exception ex)
                {
                    workTransaction.Rollback();
                    // ---- Restore the dataset -----------
                    if (this.BackupDataSetBeforeUpdate)
                    {
                        global::System.Diagnostics.Debug.Assert((backupDataSet != null));
                        dataSet.Clear();
                        dataSet.Merge(backupDataSet);
                    }
                    else
                    {
                        if ((0 < allAddedRows.Count))
                        {
                            global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                            allAddedRows.CopyTo(rows);
                            for (int i = 0; (i < rows.Length); i = (i + 1))
                            {
                                global::System.Data.DataRow row = rows[i];
                                row.AcceptChanges();
                                row.SetAdded();
                            }
                        }
                    }
                    throw ex;
                }
                finally
                {
                    if (workConnOpened)
                    {
                        workConnection.Close();
                    }
                    if ((this._расписаниеTableAdapter != null))
                    {
                        this._расписаниеTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._расписаниеTableAdapter]));
                        this._расписаниеTableAdapter.Transaction = null;
                    }
                    if ((this._сеткиTableAdapter != null))
                    {
                        this._сеткиTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._сеткиTableAdapter]));
                        this._сеткиTableAdapter.Transaction = null;
                    }
                    if ((this._списки_участниковTableAdapter != null))
                    {
                        this._списки_участниковTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._списки_участниковTableAdapter]));
                        this._списки_участниковTableAdapter.Transaction = null;
                    }
                    if ((this._справочник_игроковTableAdapter != null))
                    {
                        this._справочник_игроковTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._справочник_игроковTableAdapter]));
                        this._справочник_игроковTableAdapter.Transaction = null;
                    }
                    if ((this._справочник_катерогийTableAdapter != null))
                    {
                        this._справочник_катерогийTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._справочник_катерогийTableAdapter]));
                        this._справочник_катерогийTableAdapter.Transaction = null;
                    }
                    if ((this._справочник_кортовTableAdapter != null))
                    {
                        this._справочник_кортовTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._справочник_кортовTableAdapter]));
                        this._справочник_кортовTableAdapter.Transaction = null;
                    }
                    if ((this._справочник_систем_проведенияTableAdapter != null))
                    {
                        this._справочник_систем_проведенияTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._справочник_систем_проведенияTableAdapter]));
                        this._справочник_систем_проведенияTableAdapter.Transaction = null;
                    }
                    if ((this._справочник_этапов_турнираTableAdapter != null))
                    {
                        this._справочник_этапов_турнираTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._справочник_этапов_турнираTableAdapter]));
                        this._справочник_этапов_турнираTableAdapter.Transaction = null;
                    }
                    if ((this._турнирыTableAdapter != null))
                    {
                        this._турнирыTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._турнирыTableAdapter]));
                        this._турнирыTableAdapter.Transaction = null;
                    }
                    if ((0 < adaptersWithAcceptChangesDuringUpdate.Count))
                    {
                        global::System.Data.Common.DataAdapter[] adapters = new System.Data.Common.DataAdapter[adaptersWithAcceptChangesDuringUpdate.Count];
                        adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters);
                        for (int i = 0; (i < adapters.Length); i = (i + 1))
                        {
                            global::System.Data.Common.DataAdapter adapter = adapters[i];
                            adapter.AcceptChangesDuringUpdate = true;
                        }
                    }
                }
                return result;
            }


            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected virtual void SortSelfReferenceRows(global::System.Data.DataRow[] rows, global::System.Data.DataRelation relation, bool childFirst)
            {
                global::System.Array.Sort<global::System.Data.DataRow>(rows, new SelfReferenceComparer(relation, childFirst));
            }


            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected virtual bool MatchTableAdapterConnection(global::System.Data.IDbConnection inputConnection)
            {
                if ((this._connection != null))
                {
                    return true;
                }
                if (((this.Connection == null)
                            || (inputConnection == null)))
                {
                    return true;
                }
                if (string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, global::System.StringComparison.Ordinal))
                {
                    return true;
                }
                return false;
            }

            /// <summary>
            ///Update Order Option
            ///</summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public enum UpdateOrderOption
            {

                InsertUpdateDelete = 0,

                UpdateInsertDelete = 1,
            }

            /// <summary>
            ///Used to sort self-referenced table's rows
            ///</summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private class SelfReferenceComparer : object, global::System.Collections.Generic.IComparer<global::System.Data.DataRow>
            {

                private global::System.Data.DataRelation _relation;

                private int _childFirst;


                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
                internal SelfReferenceComparer(global::System.Data.DataRelation relation, bool childFirst)
                {
                    this._relation = relation;
                    if (childFirst)
                    {
                        this._childFirst = -1;
                    }
                    else
                    {
                        this._childFirst = 1;
                    }
                }


                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
                private global::System.Data.DataRow GetRoot(global::System.Data.DataRow row, out int distance)
                {
                    global::System.Diagnostics.Debug.Assert((row != null));
                    global::System.Data.DataRow root = row;
                    distance = 0;

                    global::System.Collections.Generic.IDictionary<global::System.Data.DataRow, global::System.Data.DataRow> traversedRows = new global::System.Collections.Generic.Dictionary<global::System.Data.DataRow, global::System.Data.DataRow>();
                    traversedRows[row] = row;

                    global::System.Data.DataRow parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                    for (
                    ; ((parent != null)
                                && (traversedRows.ContainsKey(parent) == false));
                    )
                    {
                        distance = (distance + 1);
                        root = parent;
                        traversedRows[parent] = parent;
                        parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                    }

                    if ((distance == 0))
                    {
                        traversedRows.Clear();
                        traversedRows[row] = row;
                        parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                        for (
                        ; ((parent != null)
                                    && (traversedRows.ContainsKey(parent) == false));
                        )
                        {
                            distance = (distance + 1);
                            root = parent;
                            traversedRows[parent] = parent;
                            parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                        }
                    }

                    return root;
                }


                [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
                public int Compare(global::System.Data.DataRow row1, global::System.Data.DataRow row2)
                {
                    if (object.ReferenceEquals(row1, row2))
                    {
                        return 0;
                    }
                    if ((row1 == null))
                    {
                        return -1;
                    }
                    if ((row2 == null))
                    {
                        return 1;
                    }

                    int distance1 = 0;
                    global::System.Data.DataRow root1 = this.GetRoot(row1, out distance1);

                    int distance2 = 0;
                    global::System.Data.DataRow root2 = this.GetRoot(row2, out distance2);

                    if (object.ReferenceEquals(root1, root2))
                    {
                        return (this._childFirst * distance1.CompareTo(distance2));
                    }
                    else
                    {
                        global::System.Diagnostics.Debug.Assert(((root1.Table != null)
                                        && (root2.Table != null)));
                        if ((root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2)))
                        {
                            return -1;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
}

#pragma warning restore 1591
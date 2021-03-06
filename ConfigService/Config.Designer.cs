﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace ConfigService
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ConfigEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ConfigEntities object using the connection string found in the 'ConfigEntities' section of the application configuration file.
        /// </summary>
        public ConfigEntities() : base("name=ConfigEntities", "ConfigEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ConfigEntities object.
        /// </summary>
        public ConfigEntities(string connectionString) : base(connectionString, "ConfigEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ConfigEntities object.
        /// </summary>
        public ConfigEntities(EntityConnection connection) : base(connection, "ConfigEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ConnectionString> ConnectionStrings
        {
            get
            {
                if ((_ConnectionStrings == null))
                {
                    _ConnectionStrings = base.CreateObjectSet<ConnectionString>("ConnectionStrings");
                }
                return _ConnectionStrings;
            }
        }
        private ObjectSet<ConnectionString> _ConnectionStrings;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ConnectionStrings EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToConnectionStrings(ConnectionString connectionString)
        {
            base.AddObject("ConnectionStrings", connectionString);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ConfigModel", Name="ConnectionString")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ConnectionString : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ConnectionString object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="data">Initial value of the Data property.</param>
        /// <param name="lastModified">Initial value of the LastModified property.</param>
        /// <param name="lastModifiedBy">Initial value of the LastModifiedBy property.</param>
        public static ConnectionString CreateConnectionString(global::System.Int32 id, global::System.String name, global::System.String data, global::System.DateTime lastModified, global::System.String lastModifiedBy)
        {
            ConnectionString connectionString = new ConnectionString();
            connectionString.Id = id;
            connectionString.Name = name;
            connectionString.Data = data;
            connectionString.LastModified = lastModified;
            connectionString.LastModifiedBy = lastModifiedBy;
            return connectionString;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Data
        {
            get
            {
                return _Data;
            }
            set
            {
                OnDataChanging(value);
                ReportPropertyChanging("Data");
                _Data = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Data");
                OnDataChanged();
            }
        }
        private global::System.String _Data;
        partial void OnDataChanging(global::System.String value);
        partial void OnDataChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime LastModified
        {
            get
            {
                return _LastModified;
            }
            set
            {
                OnLastModifiedChanging(value);
                ReportPropertyChanging("LastModified");
                _LastModified = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastModified");
                OnLastModifiedChanged();
            }
        }
        private global::System.DateTime _LastModified;
        partial void OnLastModifiedChanging(global::System.DateTime value);
        partial void OnLastModifiedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastModifiedBy
        {
            get
            {
                return _LastModifiedBy;
            }
            set
            {
                OnLastModifiedByChanging(value);
                ReportPropertyChanging("LastModifiedBy");
                _LastModifiedBy = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastModifiedBy");
                OnLastModifiedByChanged();
            }
        }
        private global::System.String _LastModifiedBy;
        partial void OnLastModifiedByChanging(global::System.String value);
        partial void OnLastModifiedByChanged();

        #endregion
    
    }

    #endregion
    
}

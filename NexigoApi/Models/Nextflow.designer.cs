﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NexigoApi.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Nexigo")]
	public partial class NextflowDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTableLeave(TableLeave instance);
    partial void UpdateTableLeave(TableLeave instance);
    partial void DeleteTableLeave(TableLeave instance);
    partial void InsertUserId(UserId instance);
    partial void UpdateUserId(UserId instance);
    partial void DeleteUserId(UserId instance);
    #endregion
		
		public NextflowDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["NexigoConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public NextflowDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NextflowDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NextflowDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NextflowDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TableLeave> TableLeaves
		{
			get
			{
				return this.GetTable<TableLeave>();
			}
		}
		
		public System.Data.Linq.Table<UserId> UserIds
		{
			get
			{
				return this.GetTable<UserId>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TableLeave")]
	public partial class TableLeave : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _TaskId;
		
		private string _Request;
		
		private string _Email;
		
		private string _Comment;
		
		private System.Nullable<int> _Jumlah_Cuti;
		
		private string _Username;
		
		private string _ProcessId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTaskIdChanging(string value);
    partial void OnTaskIdChanged();
    partial void OnRequestChanging(string value);
    partial void OnRequestChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnCommentChanging(string value);
    partial void OnCommentChanged();
    partial void OnJumlah_CutiChanging(System.Nullable<int> value);
    partial void OnJumlah_CutiChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnProcessIdChanging(string value);
    partial void OnProcessIdChanged();
    #endregion
		
		public TableLeave()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskId", DbType="NVarChar(100)")]
		public string TaskId
		{
			get
			{
				return this._TaskId;
			}
			set
			{
				if ((this._TaskId != value))
				{
					this.OnTaskIdChanging(value);
					this.SendPropertyChanging();
					this._TaskId = value;
					this.SendPropertyChanged("TaskId");
					this.OnTaskIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Request", DbType="NVarChar(100)")]
		public string Request
		{
			get
			{
				return this._Request;
			}
			set
			{
				if ((this._Request != value))
				{
					this.OnRequestChanging(value);
					this.SendPropertyChanging();
					this._Request = value;
					this.SendPropertyChanged("Request");
					this.OnRequestChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(100)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comment", DbType="NVarChar(100)")]
		public string Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				if ((this._Comment != value))
				{
					this.OnCommentChanging(value);
					this.SendPropertyChanging();
					this._Comment = value;
					this.SendPropertyChanged("Comment");
					this.OnCommentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Jumlah_Cuti", DbType="Int")]
		public System.Nullable<int> Jumlah_Cuti
		{
			get
			{
				return this._Jumlah_Cuti;
			}
			set
			{
				if ((this._Jumlah_Cuti != value))
				{
					this.OnJumlah_CutiChanging(value);
					this.SendPropertyChanging();
					this._Jumlah_Cuti = value;
					this.SendPropertyChanged("Jumlah_Cuti");
					this.OnJumlah_CutiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProcessId", DbType="NVarChar(50)")]
		public string ProcessId
		{
			get
			{
				return this._ProcessId;
			}
			set
			{
				if ((this._ProcessId != value))
				{
					this.OnProcessIdChanging(value);
					this.SendPropertyChanging();
					this._ProcessId = value;
					this.SendPropertyChanged("ProcessId");
					this.OnProcessIdChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserId")]
	public partial class UserId : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Email;
		
		private string _Password;
		
		private string _Token;
		
		private string _Pinnumber;
		
		private string _Username;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnTokenChanging(string value);
    partial void OnTokenChanged();
    partial void OnPinnumberChanging(string value);
    partial void OnPinnumberChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    #endregion
		
		public UserId()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Token", DbType="NVarChar(200)")]
		public string Token
		{
			get
			{
				return this._Token;
			}
			set
			{
				if ((this._Token != value))
				{
					this.OnTokenChanging(value);
					this.SendPropertyChanging();
					this._Token = value;
					this.SendPropertyChanged("Token");
					this.OnTokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pinnumber", DbType="NVarChar(50)")]
		public string Pinnumber
		{
			get
			{
				return this._Pinnumber;
			}
			set
			{
				if ((this._Pinnumber != value))
				{
					this.OnPinnumberChanging(value);
					this.SendPropertyChanging();
					this._Pinnumber = value;
					this.SendPropertyChanged("Pinnumber");
					this.OnPinnumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
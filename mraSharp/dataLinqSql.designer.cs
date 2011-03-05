﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mraSharp
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DataStore")]
	public partial class dataLinqSqlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertmangaList(mangaList instance);
    partial void UpdatemangaList(mangaList instance);
    partial void DeletemangaList(mangaList instance);
    partial void InsertnewsStorage(newsStorage instance);
    partial void UpdatenewsStorage(newsStorage instance);
    partial void DeletenewsStorage(newsStorage instance);
    partial void InsertrssSubscription(rssSubscription instance);
    partial void UpdaterssSubscription(rssSubscription instance);
    partial void DeleterssSubscription(rssSubscription instance);
    #endregion
		
		public dataLinqSqlDataContext() : 
				base(global::mraSharp.Properties.Settings.Default.DataStoreConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dataLinqSqlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dataLinqSqlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dataLinqSqlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dataLinqSqlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<mangaList> mangaLists
		{
			get
			{
				return this.GetTable<mangaList>();
			}
		}
		
		public System.Data.Linq.Table<newsStorage> newsStorages
		{
			get
			{
				return this.GetTable<newsStorage>();
			}
		}
		
		public System.Data.Linq.Table<rssSubscription> rssSubscriptions
		{
			get
			{
				return this.GetTable<rssSubscription>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mangaList")]
	public partial class mangaList : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _mangaTitle;
		
		private System.Nullable<double> _startingChapter;
		
		private System.Nullable<double> _currentChapter;
		
		private System.Nullable<System.DateTime> _dateRead;
		
		private string _onlineURL;
		
		private System.Nullable<bool> _isFinished;
		
		private string _mangaDescription;
		
		private string _mangaNote;
		
		private System.Data.Linq.Binary _mangaCover;
		
		private EntityRef<mangaList> _mangaList2;
		
		private EntityRef<mangaList> _mangaList1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmangaTitleChanging(string value);
    partial void OnmangaTitleChanged();
    partial void OnstartingChapterChanging(System.Nullable<double> value);
    partial void OnstartingChapterChanged();
    partial void OncurrentChapterChanging(System.Nullable<double> value);
    partial void OncurrentChapterChanged();
    partial void OndateReadChanging(System.Nullable<System.DateTime> value);
    partial void OndateReadChanged();
    partial void OnonlineURLChanging(string value);
    partial void OnonlineURLChanged();
    partial void OnisFinishedChanging(System.Nullable<bool> value);
    partial void OnisFinishedChanged();
    partial void OnmangaDescriptionChanging(string value);
    partial void OnmangaDescriptionChanged();
    partial void OnmangaNoteChanging(string value);
    partial void OnmangaNoteChanged();
    partial void OnmangaCoverChanging(System.Data.Linq.Binary value);
    partial void OnmangaCoverChanged();
    #endregion
		
		public mangaList()
		{
			this._mangaList2 = default(EntityRef<mangaList>);
			this._mangaList1 = default(EntityRef<mangaList>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mangaTitle", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string mangaTitle
		{
			get
			{
				return this._mangaTitle;
			}
			set
			{
				if ((this._mangaTitle != value))
				{
					if (this._mangaList1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmangaTitleChanging(value);
					this.SendPropertyChanging();
					this._mangaTitle = value;
					this.SendPropertyChanged("mangaTitle");
					this.OnmangaTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_startingChapter", DbType="Float")]
		public System.Nullable<double> startingChapter
		{
			get
			{
				return this._startingChapter;
			}
			set
			{
				if ((this._startingChapter != value))
				{
					this.OnstartingChapterChanging(value);
					this.SendPropertyChanging();
					this._startingChapter = value;
					this.SendPropertyChanged("startingChapter");
					this.OnstartingChapterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_currentChapter", DbType="Float")]
		public System.Nullable<double> currentChapter
		{
			get
			{
				return this._currentChapter;
			}
			set
			{
				if ((this._currentChapter != value))
				{
					this.OncurrentChapterChanging(value);
					this.SendPropertyChanging();
					this._currentChapter = value;
					this.SendPropertyChanged("currentChapter");
					this.OncurrentChapterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateRead", DbType="Date")]
		public System.Nullable<System.DateTime> dateRead
		{
			get
			{
				return this._dateRead;
			}
			set
			{
				if ((this._dateRead != value))
				{
					this.OndateReadChanging(value);
					this.SendPropertyChanging();
					this._dateRead = value;
					this.SendPropertyChanged("dateRead");
					this.OndateReadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_onlineURL", DbType="NVarChar(500)")]
		public string onlineURL
		{
			get
			{
				return this._onlineURL;
			}
			set
			{
				if ((this._onlineURL != value))
				{
					this.OnonlineURLChanging(value);
					this.SendPropertyChanging();
					this._onlineURL = value;
					this.SendPropertyChanged("onlineURL");
					this.OnonlineURLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isFinished", DbType="Bit")]
		public System.Nullable<bool> isFinished
		{
			get
			{
				return this._isFinished;
			}
			set
			{
				if ((this._isFinished != value))
				{
					this.OnisFinishedChanging(value);
					this.SendPropertyChanging();
					this._isFinished = value;
					this.SendPropertyChanged("isFinished");
					this.OnisFinishedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mangaDescription", DbType="NVarChar(MAX)")]
		public string mangaDescription
		{
			get
			{
				return this._mangaDescription;
			}
			set
			{
				if ((this._mangaDescription != value))
				{
					this.OnmangaDescriptionChanging(value);
					this.SendPropertyChanging();
					this._mangaDescription = value;
					this.SendPropertyChanged("mangaDescription");
					this.OnmangaDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mangaNote", DbType="NVarChar(MAX)")]
		public string mangaNote
		{
			get
			{
				return this._mangaNote;
			}
			set
			{
				if ((this._mangaNote != value))
				{
					this.OnmangaNoteChanging(value);
					this.SendPropertyChanging();
					this._mangaNote = value;
					this.SendPropertyChanged("mangaNote");
					this.OnmangaNoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mangaCover", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary mangaCover
		{
			get
			{
				return this._mangaCover;
			}
			set
			{
				if ((this._mangaCover != value))
				{
					this.OnmangaCoverChanging(value);
					this.SendPropertyChanging();
					this._mangaCover = value;
					this.SendPropertyChanged("mangaCover");
					this.OnmangaCoverChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="mangaList_mangaList", Storage="_mangaList2", ThisKey="mangaTitle", OtherKey="mangaTitle", IsUnique=true, IsForeignKey=false)]
		public mangaList mangaList2
		{
			get
			{
				return this._mangaList2.Entity;
			}
			set
			{
				mangaList previousValue = this._mangaList2.Entity;
				if (((previousValue != value) 
							|| (this._mangaList2.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._mangaList2.Entity = null;
						previousValue.mangaList1 = null;
					}
					this._mangaList2.Entity = value;
					if ((value != null))
					{
						value.mangaList1 = this;
					}
					this.SendPropertyChanged("mangaList2");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="mangaList_mangaList", Storage="_mangaList1", ThisKey="mangaTitle", OtherKey="mangaTitle", IsForeignKey=true)]
		public mangaList mangaList1
		{
			get
			{
				return this._mangaList1.Entity;
			}
			set
			{
				mangaList previousValue = this._mangaList1.Entity;
				if (((previousValue != value) 
							|| (this._mangaList1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._mangaList1.Entity = null;
						previousValue.mangaList2 = null;
					}
					this._mangaList1.Entity = value;
					if ((value != null))
					{
						value.mangaList2 = this;
						this._mangaTitle = value.mangaTitle;
					}
					else
					{
						this._mangaTitle = default(string);
					}
					this.SendPropertyChanged("mangaList1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.newsStorage")]
	public partial class newsStorage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _rssPK;
		
		private string _rssTitle;
		
		private string _rssLink;
		
		private string _rssDescription;
		
		private System.Nullable<System.DateTime> _rssDateAquired;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnrssPKChanging(int value);
    partial void OnrssPKChanged();
    partial void OnrssTitleChanging(string value);
    partial void OnrssTitleChanged();
    partial void OnrssLinkChanging(string value);
    partial void OnrssLinkChanged();
    partial void OnrssDescriptionChanging(string value);
    partial void OnrssDescriptionChanged();
    partial void OnrssDateAquiredChanging(System.Nullable<System.DateTime> value);
    partial void OnrssDateAquiredChanged();
    #endregion
		
		public newsStorage()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rssPK", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int rssPK
		{
			get
			{
				return this._rssPK;
			}
			set
			{
				if ((this._rssPK != value))
				{
					this.OnrssPKChanging(value);
					this.SendPropertyChanging();
					this._rssPK = value;
					this.SendPropertyChanged("rssPK");
					this.OnrssPKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rssTitle", DbType="NVarChar(500)")]
		public string rssTitle
		{
			get
			{
				return this._rssTitle;
			}
			set
			{
				if ((this._rssTitle != value))
				{
					this.OnrssTitleChanging(value);
					this.SendPropertyChanging();
					this._rssTitle = value;
					this.SendPropertyChanged("rssTitle");
					this.OnrssTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rssLink", DbType="NVarChar(500)")]
		public string rssLink
		{
			get
			{
				return this._rssLink;
			}
			set
			{
				if ((this._rssLink != value))
				{
					this.OnrssLinkChanging(value);
					this.SendPropertyChanging();
					this._rssLink = value;
					this.SendPropertyChanged("rssLink");
					this.OnrssLinkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rssDescription", DbType="NVarChar(1500)")]
		public string rssDescription
		{
			get
			{
				return this._rssDescription;
			}
			set
			{
				if ((this._rssDescription != value))
				{
					this.OnrssDescriptionChanging(value);
					this.SendPropertyChanging();
					this._rssDescription = value;
					this.SendPropertyChanged("rssDescription");
					this.OnrssDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rssDateAquired", DbType="Date")]
		public System.Nullable<System.DateTime> rssDateAquired
		{
			get
			{
				return this._rssDateAquired;
			}
			set
			{
				if ((this._rssDateAquired != value))
				{
					this.OnrssDateAquiredChanging(value);
					this.SendPropertyChanging();
					this._rssDateAquired = value;
					this.SendPropertyChanged("rssDateAquired");
					this.OnrssDateAquiredChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.rssSubscriptions")]
	public partial class rssSubscription : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _rssPK;
		
		private string _rssUrl;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnrssPKChanging(int value);
    partial void OnrssPKChanged();
    partial void OnrssUrlChanging(string value);
    partial void OnrssUrlChanged();
    #endregion
		
		public rssSubscription()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rssPK", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int rssPK
		{
			get
			{
				return this._rssPK;
			}
			set
			{
				if ((this._rssPK != value))
				{
					this.OnrssPKChanging(value);
					this.SendPropertyChanging();
					this._rssPK = value;
					this.SendPropertyChanged("rssPK");
					this.OnrssPKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rssUrl", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string rssUrl
		{
			get
			{
				return this._rssUrl;
			}
			set
			{
				if ((this._rssUrl != value))
				{
					this.OnrssUrlChanging(value);
					this.SendPropertyChanging();
					this._rssUrl = value;
					this.SendPropertyChanged("rssUrl");
					this.OnrssUrlChanged();
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

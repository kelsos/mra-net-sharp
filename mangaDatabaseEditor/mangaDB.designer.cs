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

namespace mangaDatabaseEditor
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
	public partial class MangaDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertmangaInfo(mangaInfo instance);
    partial void UpdatemangaInfo(mangaInfo instance);
    partial void DeletemangaInfo(mangaInfo instance);
    partial void InsertauthorTable(authorTable instance);
    partial void UpdateauthorTable(authorTable instance);
    partial void DeleteauthorTable(authorTable instance);
    partial void InsertmangaAuthor(mangaAuthor instance);
    partial void UpdatemangaAuthor(mangaAuthor instance);
    partial void DeletemangaAuthor(mangaAuthor instance);
    partial void InsertgenreInfo(genreInfo instance);
    partial void UpdategenreInfo(genreInfo instance);
    partial void DeletegenreInfo(genreInfo instance);
    partial void InsertmangaGenre(mangaGenre instance);
    partial void UpdatemangaGenre(mangaGenre instance);
    partial void DeletemangaGenre(mangaGenre instance);
    partial void InsertpublisherInfo(publisherInfo instance);
    partial void UpdatepublisherInfo(publisherInfo instance);
    partial void DeletepublisherInfo(publisherInfo instance);
    #endregion
		
		public MangaDBDataContext() : 
				base(global::mangaDatabaseEditor.Properties.Settings.Default.DataStoreConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MangaDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MangaDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MangaDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MangaDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<mangaInfo> mangaInfos
		{
			get
			{
				return this.GetTable<mangaInfo>();
			}
		}
		
		public System.Data.Linq.Table<authorTable> authorTables
		{
			get
			{
				return this.GetTable<authorTable>();
			}
		}
		
		public System.Data.Linq.Table<mangaAuthor> mangaAuthors
		{
			get
			{
				return this.GetTable<mangaAuthor>();
			}
		}
		
		public System.Data.Linq.Table<genreInfo> genreInfos
		{
			get
			{
				return this.GetTable<genreInfo>();
			}
		}
		
		public System.Data.Linq.Table<mangaGenre> mangaGenres
		{
			get
			{
				return this.GetTable<mangaGenre>();
			}
		}
		
		public System.Data.Linq.Table<publisherInfo> publisherInfos
		{
			get
			{
				return this.GetTable<publisherInfo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mangaInfo")]
	public partial class mangaInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _mangaID;
		
		private string _mangaTitle;
		
		private string _mangaDescription;
		
		private System.Nullable<int> _authorID;
		
		private System.Nullable<System.DateTime> _dateOfPublish;
		
		private string _mangaStatus;
		
		private System.Data.Linq.Binary _mangaCover;
		
		private System.Nullable<int> _publisherID;
		
		private EntitySet<mangaAuthor> _mangaAuthors;
		
		private EntitySet<mangaGenre> _mangaGenres;
		
		private EntityRef<publisherInfo> _publisherInfo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmangaIDChanging(int value);
    partial void OnmangaIDChanged();
    partial void OnmangaTitleChanging(string value);
    partial void OnmangaTitleChanged();
    partial void OnmangaDescriptionChanging(string value);
    partial void OnmangaDescriptionChanged();
    partial void OnauthorIDChanging(System.Nullable<int> value);
    partial void OnauthorIDChanged();
    partial void OndateOfPublishChanging(System.Nullable<System.DateTime> value);
    partial void OndateOfPublishChanged();
    partial void OnmangaStatusChanging(string value);
    partial void OnmangaStatusChanged();
    partial void OnmangaCoverChanging(System.Data.Linq.Binary value);
    partial void OnmangaCoverChanged();
    partial void OnpublisherIDChanging(System.Nullable<int> value);
    partial void OnpublisherIDChanged();
    #endregion
		
		public mangaInfo()
		{
			this._mangaAuthors = new EntitySet<mangaAuthor>(new Action<mangaAuthor>(this.attach_mangaAuthors), new Action<mangaAuthor>(this.detach_mangaAuthors));
			this._mangaGenres = new EntitySet<mangaGenre>(new Action<mangaGenre>(this.attach_mangaGenres), new Action<mangaGenre>(this.detach_mangaGenres));
			this._publisherInfo = default(EntityRef<publisherInfo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mangaID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int mangaID
		{
			get
			{
				return this._mangaID;
			}
			set
			{
				if ((this._mangaID != value))
				{
					this.OnmangaIDChanging(value);
					this.SendPropertyChanging();
					this._mangaID = value;
					this.SendPropertyChanged("mangaID");
					this.OnmangaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mangaTitle", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
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
					this.OnmangaTitleChanging(value);
					this.SendPropertyChanging();
					this._mangaTitle = value;
					this.SendPropertyChanged("mangaTitle");
					this.OnmangaTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mangaDescription", DbType="VarChar(1000)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authorID", DbType="Int")]
		public System.Nullable<int> authorID
		{
			get
			{
				return this._authorID;
			}
			set
			{
				if ((this._authorID != value))
				{
					this.OnauthorIDChanging(value);
					this.SendPropertyChanging();
					this._authorID = value;
					this.SendPropertyChanged("authorID");
					this.OnauthorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateOfPublish", DbType="Date")]
		public System.Nullable<System.DateTime> dateOfPublish
		{
			get
			{
				return this._dateOfPublish;
			}
			set
			{
				if ((this._dateOfPublish != value))
				{
					this.OndateOfPublishChanging(value);
					this.SendPropertyChanging();
					this._dateOfPublish = value;
					this.SendPropertyChanged("dateOfPublish");
					this.OndateOfPublishChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mangaStatus", DbType="NVarChar(10)")]
		public string mangaStatus
		{
			get
			{
				return this._mangaStatus;
			}
			set
			{
				if ((this._mangaStatus != value))
				{
					this.OnmangaStatusChanging(value);
					this.SendPropertyChanging();
					this._mangaStatus = value;
					this.SendPropertyChanged("mangaStatus");
					this.OnmangaStatusChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_publisherID", DbType="Int")]
		public System.Nullable<int> publisherID
		{
			get
			{
				return this._publisherID;
			}
			set
			{
				if ((this._publisherID != value))
				{
					if (this._publisherInfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnpublisherIDChanging(value);
					this.SendPropertyChanging();
					this._publisherID = value;
					this.SendPropertyChanged("publisherID");
					this.OnpublisherIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="mangaInfo_mangaAuthor", Storage="_mangaAuthors", ThisKey="mangaID", OtherKey="mangaID")]
		public EntitySet<mangaAuthor> mangaAuthors
		{
			get
			{
				return this._mangaAuthors;
			}
			set
			{
				this._mangaAuthors.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="mangaInfo_mangaGenre", Storage="_mangaGenres", ThisKey="mangaID", OtherKey="mangaID")]
		public EntitySet<mangaGenre> mangaGenres
		{
			get
			{
				return this._mangaGenres;
			}
			set
			{
				this._mangaGenres.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="publisherInfo_mangaInfo", Storage="_publisherInfo", ThisKey="publisherID", OtherKey="publisherID", IsForeignKey=true)]
		public publisherInfo publisherInfo
		{
			get
			{
				return this._publisherInfo.Entity;
			}
			set
			{
				publisherInfo previousValue = this._publisherInfo.Entity;
				if (((previousValue != value) 
							|| (this._publisherInfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._publisherInfo.Entity = null;
						previousValue.mangaInfos.Remove(this);
					}
					this._publisherInfo.Entity = value;
					if ((value != null))
					{
						value.mangaInfos.Add(this);
						this._publisherID = value.publisherID;
					}
					else
					{
						this._publisherID = default(Nullable<int>);
					}
					this.SendPropertyChanged("publisherInfo");
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
		
		private void attach_mangaAuthors(mangaAuthor entity)
		{
			this.SendPropertyChanging();
			entity.mangaInfo = this;
		}
		
		private void detach_mangaAuthors(mangaAuthor entity)
		{
			this.SendPropertyChanging();
			entity.mangaInfo = null;
		}
		
		private void attach_mangaGenres(mangaGenre entity)
		{
			this.SendPropertyChanging();
			entity.mangaInfo = this;
		}
		
		private void detach_mangaGenres(mangaGenre entity)
		{
			this.SendPropertyChanging();
			entity.mangaInfo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.authorTable")]
	public partial class authorTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _authorID;
		
		private string _authorFullName;
		
		private string _authorCountryOfOrigin;
		
		private System.Nullable<System.DateTime> _authorDateOfBirth;
		
		private string _authorWebsite;
		
		private EntitySet<mangaAuthor> _mangaAuthors;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnauthorIDChanging(int value);
    partial void OnauthorIDChanged();
    partial void OnauthorFullNameChanging(string value);
    partial void OnauthorFullNameChanged();
    partial void OnauthorCountryOfOriginChanging(string value);
    partial void OnauthorCountryOfOriginChanged();
    partial void OnauthorDateOfBirthChanging(System.Nullable<System.DateTime> value);
    partial void OnauthorDateOfBirthChanged();
    partial void OnauthorWebsiteChanging(string value);
    partial void OnauthorWebsiteChanged();
    #endregion
		
		public authorTable()
		{
			this._mangaAuthors = new EntitySet<mangaAuthor>(new Action<mangaAuthor>(this.attach_mangaAuthors), new Action<mangaAuthor>(this.detach_mangaAuthors));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authorID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int authorID
		{
			get
			{
				return this._authorID;
			}
			set
			{
				if ((this._authorID != value))
				{
					this.OnauthorIDChanging(value);
					this.SendPropertyChanging();
					this._authorID = value;
					this.SendPropertyChanged("authorID");
					this.OnauthorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authorFullName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string authorFullName
		{
			get
			{
				return this._authorFullName;
			}
			set
			{
				if ((this._authorFullName != value))
				{
					this.OnauthorFullNameChanging(value);
					this.SendPropertyChanging();
					this._authorFullName = value;
					this.SendPropertyChanged("authorFullName");
					this.OnauthorFullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authorCountryOfOrigin", DbType="NVarChar(40)")]
		public string authorCountryOfOrigin
		{
			get
			{
				return this._authorCountryOfOrigin;
			}
			set
			{
				if ((this._authorCountryOfOrigin != value))
				{
					this.OnauthorCountryOfOriginChanging(value);
					this.SendPropertyChanging();
					this._authorCountryOfOrigin = value;
					this.SendPropertyChanged("authorCountryOfOrigin");
					this.OnauthorCountryOfOriginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authorDateOfBirth", DbType="Date")]
		public System.Nullable<System.DateTime> authorDateOfBirth
		{
			get
			{
				return this._authorDateOfBirth;
			}
			set
			{
				if ((this._authorDateOfBirth != value))
				{
					this.OnauthorDateOfBirthChanging(value);
					this.SendPropertyChanging();
					this._authorDateOfBirth = value;
					this.SendPropertyChanged("authorDateOfBirth");
					this.OnauthorDateOfBirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authorWebsite", DbType="NVarChar(150)")]
		public string authorWebsite
		{
			get
			{
				return this._authorWebsite;
			}
			set
			{
				if ((this._authorWebsite != value))
				{
					this.OnauthorWebsiteChanging(value);
					this.SendPropertyChanging();
					this._authorWebsite = value;
					this.SendPropertyChanged("authorWebsite");
					this.OnauthorWebsiteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="authorTable_mangaAuthor", Storage="_mangaAuthors", ThisKey="authorID", OtherKey="authorID")]
		public EntitySet<mangaAuthor> mangaAuthors
		{
			get
			{
				return this._mangaAuthors;
			}
			set
			{
				this._mangaAuthors.Assign(value);
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
		
		private void attach_mangaAuthors(mangaAuthor entity)
		{
			this.SendPropertyChanging();
			entity.authorTable = this;
		}
		
		private void detach_mangaAuthors(mangaAuthor entity)
		{
			this.SendPropertyChanging();
			entity.authorTable = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mangaAuthors")]
	public partial class mangaAuthor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _mangaID;
		
		private int _authorID;
		
		private EntityRef<authorTable> _authorTable;
		
		private EntityRef<mangaInfo> _mangaInfo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmangaIDChanging(int value);
    partial void OnmangaIDChanged();
    partial void OnauthorIDChanging(int value);
    partial void OnauthorIDChanged();
    #endregion
		
		public mangaAuthor()
		{
			this._authorTable = default(EntityRef<authorTable>);
			this._mangaInfo = default(EntityRef<mangaInfo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mangaID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int mangaID
		{
			get
			{
				return this._mangaID;
			}
			set
			{
				if ((this._mangaID != value))
				{
					if (this._mangaInfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmangaIDChanging(value);
					this.SendPropertyChanging();
					this._mangaID = value;
					this.SendPropertyChanged("mangaID");
					this.OnmangaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authorID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int authorID
		{
			get
			{
				return this._authorID;
			}
			set
			{
				if ((this._authorID != value))
				{
					if (this._authorTable.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnauthorIDChanging(value);
					this.SendPropertyChanging();
					this._authorID = value;
					this.SendPropertyChanged("authorID");
					this.OnauthorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="authorTable_mangaAuthor", Storage="_authorTable", ThisKey="authorID", OtherKey="authorID", IsForeignKey=true)]
		public authorTable authorTable
		{
			get
			{
				return this._authorTable.Entity;
			}
			set
			{
				authorTable previousValue = this._authorTable.Entity;
				if (((previousValue != value) 
							|| (this._authorTable.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._authorTable.Entity = null;
						previousValue.mangaAuthors.Remove(this);
					}
					this._authorTable.Entity = value;
					if ((value != null))
					{
						value.mangaAuthors.Add(this);
						this._authorID = value.authorID;
					}
					else
					{
						this._authorID = default(int);
					}
					this.SendPropertyChanged("authorTable");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="mangaInfo_mangaAuthor", Storage="_mangaInfo", ThisKey="mangaID", OtherKey="mangaID", IsForeignKey=true)]
		public mangaInfo mangaInfo
		{
			get
			{
				return this._mangaInfo.Entity;
			}
			set
			{
				mangaInfo previousValue = this._mangaInfo.Entity;
				if (((previousValue != value) 
							|| (this._mangaInfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._mangaInfo.Entity = null;
						previousValue.mangaAuthors.Remove(this);
					}
					this._mangaInfo.Entity = value;
					if ((value != null))
					{
						value.mangaAuthors.Add(this);
						this._mangaID = value.mangaID;
					}
					else
					{
						this._mangaID = default(int);
					}
					this.SendPropertyChanged("mangaInfo");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.genreInfo")]
	public partial class genreInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _genreID;
		
		private string _genreName;
		
		private EntitySet<mangaGenre> _mangaGenres;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OngenreIDChanging(int value);
    partial void OngenreIDChanged();
    partial void OngenreNameChanging(string value);
    partial void OngenreNameChanged();
    #endregion
		
		public genreInfo()
		{
			this._mangaGenres = new EntitySet<mangaGenre>(new Action<mangaGenre>(this.attach_mangaGenres), new Action<mangaGenre>(this.detach_mangaGenres));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_genreID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int genreID
		{
			get
			{
				return this._genreID;
			}
			set
			{
				if ((this._genreID != value))
				{
					this.OngenreIDChanging(value);
					this.SendPropertyChanging();
					this._genreID = value;
					this.SendPropertyChanged("genreID");
					this.OngenreIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_genreName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string genreName
		{
			get
			{
				return this._genreName;
			}
			set
			{
				if ((this._genreName != value))
				{
					this.OngenreNameChanging(value);
					this.SendPropertyChanging();
					this._genreName = value;
					this.SendPropertyChanged("genreName");
					this.OngenreNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="genreInfo_mangaGenre", Storage="_mangaGenres", ThisKey="genreID", OtherKey="genreID")]
		public EntitySet<mangaGenre> mangaGenres
		{
			get
			{
				return this._mangaGenres;
			}
			set
			{
				this._mangaGenres.Assign(value);
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
		
		private void attach_mangaGenres(mangaGenre entity)
		{
			this.SendPropertyChanging();
			entity.genreInfo = this;
		}
		
		private void detach_mangaGenres(mangaGenre entity)
		{
			this.SendPropertyChanging();
			entity.genreInfo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mangaGenres")]
	public partial class mangaGenre : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _genreID;
		
		private int _mangaID;
		
		private EntityRef<genreInfo> _genreInfo;
		
		private EntityRef<mangaInfo> _mangaInfo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OngenreIDChanging(int value);
    partial void OngenreIDChanged();
    partial void OnmangaIDChanging(int value);
    partial void OnmangaIDChanged();
    #endregion
		
		public mangaGenre()
		{
			this._genreInfo = default(EntityRef<genreInfo>);
			this._mangaInfo = default(EntityRef<mangaInfo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_genreID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int genreID
		{
			get
			{
				return this._genreID;
			}
			set
			{
				if ((this._genreID != value))
				{
					if (this._genreInfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OngenreIDChanging(value);
					this.SendPropertyChanging();
					this._genreID = value;
					this.SendPropertyChanged("genreID");
					this.OngenreIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mangaID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int mangaID
		{
			get
			{
				return this._mangaID;
			}
			set
			{
				if ((this._mangaID != value))
				{
					if (this._mangaInfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmangaIDChanging(value);
					this.SendPropertyChanging();
					this._mangaID = value;
					this.SendPropertyChanged("mangaID");
					this.OnmangaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="genreInfo_mangaGenre", Storage="_genreInfo", ThisKey="genreID", OtherKey="genreID", IsForeignKey=true)]
		public genreInfo genreInfo
		{
			get
			{
				return this._genreInfo.Entity;
			}
			set
			{
				genreInfo previousValue = this._genreInfo.Entity;
				if (((previousValue != value) 
							|| (this._genreInfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._genreInfo.Entity = null;
						previousValue.mangaGenres.Remove(this);
					}
					this._genreInfo.Entity = value;
					if ((value != null))
					{
						value.mangaGenres.Add(this);
						this._genreID = value.genreID;
					}
					else
					{
						this._genreID = default(int);
					}
					this.SendPropertyChanged("genreInfo");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="mangaInfo_mangaGenre", Storage="_mangaInfo", ThisKey="mangaID", OtherKey="mangaID", IsForeignKey=true)]
		public mangaInfo mangaInfo
		{
			get
			{
				return this._mangaInfo.Entity;
			}
			set
			{
				mangaInfo previousValue = this._mangaInfo.Entity;
				if (((previousValue != value) 
							|| (this._mangaInfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._mangaInfo.Entity = null;
						previousValue.mangaGenres.Remove(this);
					}
					this._mangaInfo.Entity = value;
					if ((value != null))
					{
						value.mangaGenres.Add(this);
						this._mangaID = value.mangaID;
					}
					else
					{
						this._mangaID = default(int);
					}
					this.SendPropertyChanged("mangaInfo");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.publisherInfo")]
	public partial class publisherInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _publisherID;
		
		private string _publisherName;
		
		private string _publisherCountry;
		
		private string _publisherWebsite;
		
		private string _publisherNote;
		
		private EntitySet<mangaInfo> _mangaInfos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpublisherIDChanging(int value);
    partial void OnpublisherIDChanged();
    partial void OnpublisherNameChanging(string value);
    partial void OnpublisherNameChanged();
    partial void OnpublisherCountryChanging(string value);
    partial void OnpublisherCountryChanged();
    partial void OnpublisherWebsiteChanging(string value);
    partial void OnpublisherWebsiteChanged();
    partial void OnpublisherNoteChanging(string value);
    partial void OnpublisherNoteChanged();
    #endregion
		
		public publisherInfo()
		{
			this._mangaInfos = new EntitySet<mangaInfo>(new Action<mangaInfo>(this.attach_mangaInfos), new Action<mangaInfo>(this.detach_mangaInfos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_publisherID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int publisherID
		{
			get
			{
				return this._publisherID;
			}
			set
			{
				if ((this._publisherID != value))
				{
					this.OnpublisherIDChanging(value);
					this.SendPropertyChanging();
					this._publisherID = value;
					this.SendPropertyChanged("publisherID");
					this.OnpublisherIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_publisherName", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string publisherName
		{
			get
			{
				return this._publisherName;
			}
			set
			{
				if ((this._publisherName != value))
				{
					this.OnpublisherNameChanging(value);
					this.SendPropertyChanging();
					this._publisherName = value;
					this.SendPropertyChanged("publisherName");
					this.OnpublisherNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_publisherCountry", DbType="NVarChar(40)")]
		public string publisherCountry
		{
			get
			{
				return this._publisherCountry;
			}
			set
			{
				if ((this._publisherCountry != value))
				{
					this.OnpublisherCountryChanging(value);
					this.SendPropertyChanging();
					this._publisherCountry = value;
					this.SendPropertyChanged("publisherCountry");
					this.OnpublisherCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_publisherWebsite", DbType="NVarChar(150)")]
		public string publisherWebsite
		{
			get
			{
				return this._publisherWebsite;
			}
			set
			{
				if ((this._publisherWebsite != value))
				{
					this.OnpublisherWebsiteChanging(value);
					this.SendPropertyChanging();
					this._publisherWebsite = value;
					this.SendPropertyChanged("publisherWebsite");
					this.OnpublisherWebsiteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_publisherNote", DbType="NVarChar(500)")]
		public string publisherNote
		{
			get
			{
				return this._publisherNote;
			}
			set
			{
				if ((this._publisherNote != value))
				{
					this.OnpublisherNoteChanging(value);
					this.SendPropertyChanging();
					this._publisherNote = value;
					this.SendPropertyChanged("publisherNote");
					this.OnpublisherNoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="publisherInfo_mangaInfo", Storage="_mangaInfos", ThisKey="publisherID", OtherKey="publisherID")]
		public EntitySet<mangaInfo> mangaInfos
		{
			get
			{
				return this._mangaInfos;
			}
			set
			{
				this._mangaInfos.Assign(value);
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
		
		private void attach_mangaInfos(mangaInfo entity)
		{
			this.SendPropertyChanging();
			entity.publisherInfo = this;
		}
		
		private void detach_mangaInfos(mangaInfo entity)
		{
			this.SendPropertyChanging();
			entity.publisherInfo = null;
		}
	}
}
#pragma warning restore 1591

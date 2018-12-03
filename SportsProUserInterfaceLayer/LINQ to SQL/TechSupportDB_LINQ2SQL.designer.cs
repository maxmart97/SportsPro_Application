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

namespace SportsProUserInterfaceLayer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TechSupport")]
	public partial class TechSupportDB_LINQ2SQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertIncident(Incident instance);
    partial void UpdateIncident(Incident instance);
    partial void DeleteIncident(Incident instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertRegistration(Registration instance);
    partial void UpdateRegistration(Registration instance);
    partial void DeleteRegistration(Registration instance);
    partial void InsertState(State instance);
    partial void UpdateState(State instance);
    partial void DeleteState(State instance);
    partial void InsertTechnician(Technician instance);
    partial void UpdateTechnician(Technician instance);
    partial void DeleteTechnician(Technician instance);
    #endregion
		
		public TechSupportDB_LINQ2SQLDataContext() : 
				base(global::SportsProUserInterfaceLayer.Properties.Settings.Default.TechSupportConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public TechSupportDB_LINQ2SQLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TechSupportDB_LINQ2SQLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TechSupportDB_LINQ2SQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TechSupportDB_LINQ2SQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Incident> Incidents
		{
			get
			{
				return this.GetTable<Incident>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Registration> Registrations
		{
			get
			{
				return this.GetTable<Registration>();
			}
		}
		
		public System.Data.Linq.Table<State> States
		{
			get
			{
				return this.GetTable<State>();
			}
		}
		
		public System.Data.Linq.Table<Technician> Technicians
		{
			get
			{
				return this.GetTable<Technician>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customers")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerID;
		
		private string _Name;
		
		private string _Address;
		
		private string _City;
		
		private string _State;
		
		private string _ZipCode;
		
		private string _Phone;
		
		private string _Email;
		
		private EntitySet<Incident> _Incidents;
		
		private EntitySet<Registration> _Registrations;
		
		private EntityRef<State> _State1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnZipCodeChanging(string value);
    partial void OnZipCodeChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public Customer()
		{
			this._Incidents = new EntitySet<Incident>(new Action<Incident>(this.attach_Incidents), new Action<Incident>(this.detach_Incidents));
			this._Registrations = new EntitySet<Registration>(new Action<Registration>(this.attach_Registrations), new Action<Registration>(this.detach_Registrations));
			this._State1 = default(EntityRef<State>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="Char(2) NOT NULL", CanBeNull=false)]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					if (this._State1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="VarChar(9) NOT NULL", CanBeNull=false)]
		public string ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this.OnZipCodeChanging(value);
					this.SendPropertyChanging();
					this._ZipCode = value;
					this.SendPropertyChanged("ZipCode");
					this.OnZipCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(20)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Incident", Storage="_Incidents", ThisKey="CustomerID", OtherKey="CustomerID")]
		public EntitySet<Incident> Incidents
		{
			get
			{
				return this._Incidents;
			}
			set
			{
				this._Incidents.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Registration", Storage="_Registrations", ThisKey="CustomerID", OtherKey="CustomerID")]
		public EntitySet<Registration> Registrations
		{
			get
			{
				return this._Registrations;
			}
			set
			{
				this._Registrations.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="State_Customer", Storage="_State1", ThisKey="State", OtherKey="StateCode", IsForeignKey=true)]
		public State State1
		{
			get
			{
				return this._State1.Entity;
			}
			set
			{
				State previousValue = this._State1.Entity;
				if (((previousValue != value) 
							|| (this._State1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._State1.Entity = null;
						previousValue.Customers.Remove(this);
					}
					this._State1.Entity = value;
					if ((value != null))
					{
						value.Customers.Add(this);
						this._State = value.StateCode;
					}
					else
					{
						this._State = default(string);
					}
					this.SendPropertyChanged("State1");
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
		
		private void attach_Incidents(Incident entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Incidents(Incident entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
		
		private void attach_Registrations(Registration entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Registrations(Registration entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Incidents")]
	public partial class Incident : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IncidentID;
		
		private int _CustomerID;
		
		private string _ProductCode;
		
		private System.Nullable<int> _TechID;
		
		private System.DateTime _DateOpened;
		
		private System.Nullable<System.DateTime> _DateClosed;
		
		private string _Title;
		
		private string _Description;
		
		private EntityRef<Customer> _Customer;
		
		private EntityRef<Product> _Product;
		
		private EntityRef<Technician> _Technician;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIncidentIDChanging(int value);
    partial void OnIncidentIDChanged();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnProductCodeChanging(string value);
    partial void OnProductCodeChanged();
    partial void OnTechIDChanging(System.Nullable<int> value);
    partial void OnTechIDChanged();
    partial void OnDateOpenedChanging(System.DateTime value);
    partial void OnDateOpenedChanged();
    partial void OnDateClosedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateClosedChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Incident()
		{
			this._Customer = default(EntityRef<Customer>);
			this._Product = default(EntityRef<Product>);
			this._Technician = default(EntityRef<Technician>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IncidentID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IncidentID
		{
			get
			{
				return this._IncidentID;
			}
			set
			{
				if ((this._IncidentID != value))
				{
					this.OnIncidentIDChanging(value);
					this.SendPropertyChanging();
					this._IncidentID = value;
					this.SendPropertyChanged("IncidentID");
					this.OnIncidentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="Int NOT NULL")]
		public int CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductCode", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string ProductCode
		{
			get
			{
				return this._ProductCode;
			}
			set
			{
				if ((this._ProductCode != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductCodeChanging(value);
					this.SendPropertyChanging();
					this._ProductCode = value;
					this.SendPropertyChanged("ProductCode");
					this.OnProductCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TechID", DbType="Int")]
		public System.Nullable<int> TechID
		{
			get
			{
				return this._TechID;
			}
			set
			{
				if ((this._TechID != value))
				{
					if (this._Technician.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTechIDChanging(value);
					this.SendPropertyChanging();
					this._TechID = value;
					this.SendPropertyChanged("TechID");
					this.OnTechIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOpened", DbType="DateTime NOT NULL")]
		public System.DateTime DateOpened
		{
			get
			{
				return this._DateOpened;
			}
			set
			{
				if ((this._DateOpened != value))
				{
					this.OnDateOpenedChanging(value);
					this.SendPropertyChanging();
					this._DateOpened = value;
					this.SendPropertyChanged("DateOpened");
					this.OnDateOpenedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateClosed", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateClosed
		{
			get
			{
				return this._DateClosed;
			}
			set
			{
				if ((this._DateClosed != value))
				{
					this.OnDateClosedChanging(value);
					this.SendPropertyChanging();
					this._DateClosed = value;
					this.SendPropertyChanged("DateClosed");
					this.OnDateClosedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(2000) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Incident", Storage="_Customer", ThisKey="CustomerID", OtherKey="CustomerID", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Incidents.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Incidents.Add(this);
						this._CustomerID = value.CustomerID;
					}
					else
					{
						this._CustomerID = default(int);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Incident", Storage="_Product", ThisKey="ProductCode", OtherKey="ProductCode", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Incidents.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Incidents.Add(this);
						this._ProductCode = value.ProductCode;
					}
					else
					{
						this._ProductCode = default(string);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Technician_Incident", Storage="_Technician", ThisKey="TechID", OtherKey="TechID", IsForeignKey=true, DeleteRule="CASCADE")]
		public Technician Technician
		{
			get
			{
				return this._Technician.Entity;
			}
			set
			{
				Technician previousValue = this._Technician.Entity;
				if (((previousValue != value) 
							|| (this._Technician.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Technician.Entity = null;
						previousValue.Incidents.Remove(this);
					}
					this._Technician.Entity = value;
					if ((value != null))
					{
						value.Incidents.Add(this);
						this._TechID = value.TechID;
					}
					else
					{
						this._TechID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Technician");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ProductCode;
		
		private string _Name;
		
		private decimal _Version;
		
		private System.DateTime _ReleaseDate;
		
		private EntitySet<Incident> _Incidents;
		
		private EntitySet<Registration> _Registrations;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductCodeChanging(string value);
    partial void OnProductCodeChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnVersionChanging(decimal value);
    partial void OnVersionChanged();
    partial void OnReleaseDateChanging(System.DateTime value);
    partial void OnReleaseDateChanged();
    #endregion
		
		public Product()
		{
			this._Incidents = new EntitySet<Incident>(new Action<Incident>(this.attach_Incidents), new Action<Incident>(this.detach_Incidents));
			this._Registrations = new EntitySet<Registration>(new Action<Registration>(this.attach_Registrations), new Action<Registration>(this.detach_Registrations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductCode", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ProductCode
		{
			get
			{
				return this._ProductCode;
			}
			set
			{
				if ((this._ProductCode != value))
				{
					this.OnProductCodeChanging(value);
					this.SendPropertyChanging();
					this._ProductCode = value;
					this.SendPropertyChanged("ProductCode");
					this.OnProductCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Version", DbType="Decimal(18,1) NOT NULL")]
		public decimal Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				if ((this._Version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._Version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReleaseDate", DbType="DateTime NOT NULL")]
		public System.DateTime ReleaseDate
		{
			get
			{
				return this._ReleaseDate;
			}
			set
			{
				if ((this._ReleaseDate != value))
				{
					this.OnReleaseDateChanging(value);
					this.SendPropertyChanging();
					this._ReleaseDate = value;
					this.SendPropertyChanged("ReleaseDate");
					this.OnReleaseDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Incident", Storage="_Incidents", ThisKey="ProductCode", OtherKey="ProductCode")]
		public EntitySet<Incident> Incidents
		{
			get
			{
				return this._Incidents;
			}
			set
			{
				this._Incidents.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Registration", Storage="_Registrations", ThisKey="ProductCode", OtherKey="ProductCode")]
		public EntitySet<Registration> Registrations
		{
			get
			{
				return this._Registrations;
			}
			set
			{
				this._Registrations.Assign(value);
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
		
		private void attach_Incidents(Incident entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Incidents(Incident entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
		
		private void attach_Registrations(Registration entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Registrations(Registration entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Registrations")]
	public partial class Registration : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerID;
		
		private string _ProductCode;
		
		private System.DateTime _RegistrationDate;
		
		private EntityRef<Customer> _Customer;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnProductCodeChanging(string value);
    partial void OnProductCodeChanged();
    partial void OnRegistrationDateChanging(System.DateTime value);
    partial void OnRegistrationDateChanged();
    #endregion
		
		public Registration()
		{
			this._Customer = default(EntityRef<Customer>);
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductCode", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ProductCode
		{
			get
			{
				return this._ProductCode;
			}
			set
			{
				if ((this._ProductCode != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductCodeChanging(value);
					this.SendPropertyChanging();
					this._ProductCode = value;
					this.SendPropertyChanged("ProductCode");
					this.OnProductCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegistrationDate", DbType="DateTime NOT NULL")]
		public System.DateTime RegistrationDate
		{
			get
			{
				return this._RegistrationDate;
			}
			set
			{
				if ((this._RegistrationDate != value))
				{
					this.OnRegistrationDateChanging(value);
					this.SendPropertyChanging();
					this._RegistrationDate = value;
					this.SendPropertyChanged("RegistrationDate");
					this.OnRegistrationDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Registration", Storage="_Customer", ThisKey="CustomerID", OtherKey="CustomerID", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Registrations.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Registrations.Add(this);
						this._CustomerID = value.CustomerID;
					}
					else
					{
						this._CustomerID = default(int);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Registration", Storage="_Product", ThisKey="ProductCode", OtherKey="ProductCode", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Registrations.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Registrations.Add(this);
						this._ProductCode = value.ProductCode;
					}
					else
					{
						this._ProductCode = default(string);
					}
					this.SendPropertyChanged("Product");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.States")]
	public partial class State : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _StateCode;
		
		private string _StateName;
		
		private int _FirstZipCode;
		
		private int _LastZipCode;
		
		private EntitySet<Customer> _Customers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStateCodeChanging(string value);
    partial void OnStateCodeChanged();
    partial void OnStateNameChanging(string value);
    partial void OnStateNameChanged();
    partial void OnFirstZipCodeChanging(int value);
    partial void OnFirstZipCodeChanged();
    partial void OnLastZipCodeChanging(int value);
    partial void OnLastZipCodeChanged();
    #endregion
		
		public State()
		{
			this._Customers = new EntitySet<Customer>(new Action<Customer>(this.attach_Customers), new Action<Customer>(this.detach_Customers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateCode", DbType="Char(2) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string StateCode
		{
			get
			{
				return this._StateCode;
			}
			set
			{
				if ((this._StateCode != value))
				{
					this.OnStateCodeChanging(value);
					this.SendPropertyChanging();
					this._StateCode = value;
					this.SendPropertyChanged("StateCode");
					this.OnStateCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string StateName
		{
			get
			{
				return this._StateName;
			}
			set
			{
				if ((this._StateName != value))
				{
					this.OnStateNameChanging(value);
					this.SendPropertyChanging();
					this._StateName = value;
					this.SendPropertyChanged("StateName");
					this.OnStateNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstZipCode", DbType="Int NOT NULL")]
		public int FirstZipCode
		{
			get
			{
				return this._FirstZipCode;
			}
			set
			{
				if ((this._FirstZipCode != value))
				{
					this.OnFirstZipCodeChanging(value);
					this.SendPropertyChanging();
					this._FirstZipCode = value;
					this.SendPropertyChanged("FirstZipCode");
					this.OnFirstZipCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastZipCode", DbType="Int NOT NULL")]
		public int LastZipCode
		{
			get
			{
				return this._LastZipCode;
			}
			set
			{
				if ((this._LastZipCode != value))
				{
					this.OnLastZipCodeChanging(value);
					this.SendPropertyChanging();
					this._LastZipCode = value;
					this.SendPropertyChanged("LastZipCode");
					this.OnLastZipCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="State_Customer", Storage="_Customers", ThisKey="StateCode", OtherKey="State")]
		public EntitySet<Customer> Customers
		{
			get
			{
				return this._Customers;
			}
			set
			{
				this._Customers.Assign(value);
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
		
		private void attach_Customers(Customer entity)
		{
			this.SendPropertyChanging();
			entity.State1 = this;
		}
		
		private void detach_Customers(Customer entity)
		{
			this.SendPropertyChanging();
			entity.State1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Technicians")]
	public partial class Technician : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TechID;
		
		private string _Name;
		
		private string _Email;
		
		private string _Phone;
		
		private EntitySet<Incident> _Incidents;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTechIDChanging(int value);
    partial void OnTechIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    #endregion
		
		public Technician()
		{
			this._Incidents = new EntitySet<Incident>(new Action<Incident>(this.attach_Incidents), new Action<Incident>(this.detach_Incidents));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TechID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TechID
		{
			get
			{
				return this._TechID;
			}
			set
			{
				if ((this._TechID != value))
				{
					this.OnTechIDChanging(value);
					this.SendPropertyChanging();
					this._TechID = value;
					this.SendPropertyChanged("TechID");
					this.OnTechIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Technician_Incident", Storage="_Incidents", ThisKey="TechID", OtherKey="TechID")]
		public EntitySet<Incident> Incidents
		{
			get
			{
				return this._Incidents;
			}
			set
			{
				this._Incidents.Assign(value);
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
		
		private void attach_Incidents(Incident entity)
		{
			this.SendPropertyChanging();
			entity.Technician = this;
		}
		
		private void detach_Incidents(Incident entity)
		{
			this.SendPropertyChanging();
			entity.Technician = null;
		}
	}
}
#pragma warning restore 1591
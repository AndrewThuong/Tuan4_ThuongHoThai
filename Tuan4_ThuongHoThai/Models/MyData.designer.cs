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

namespace Tuan4_ThuongHoThai.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="NhaSach")]
	public partial class MyDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChiTietDonHang(ChiTietDonHang instance);
    partial void UpdateChiTietDonHang(ChiTietDonHang instance);
    partial void DeleteChiTietDonHang(ChiTietDonHang instance);
    partial void InsertDonHang(DonHang instance);
    partial void UpdateDonHang(DonHang instance);
    partial void DeleteDonHang(DonHang instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertSach(Sach instance);
    partial void UpdateSach(Sach instance);
    partial void DeleteSach(Sach instance);
    partial void InsertTheLoai(TheLoai instance);
    partial void UpdateTheLoai(TheLoai instance);
    partial void DeleteTheLoai(TheLoai instance);
    #endregion
		
		public MyDataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["NhaSachConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ChiTietDonHang> ChiTietDonHangs
		{
			get
			{
				return this.GetTable<ChiTietDonHang>();
			}
		}
		
		public System.Data.Linq.Table<DonHang> DonHangs
		{
			get
			{
				return this.GetTable<DonHang>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<Sach> Saches
		{
			get
			{
				return this.GetTable<Sach>();
			}
		}
		
		public System.Data.Linq.Table<TheLoai> TheLoais
		{
			get
			{
				return this.GetTable<TheLoai>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietDonHang")]
	public partial class ChiTietDonHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _madon;
		
		private int _masach;
		
		private System.Nullable<int> _soluong;
		
		private System.Nullable<decimal> _gia;
		
		private EntityRef<DonHang> _DonHang;
		
		private EntityRef<Sach> _Sach;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmadonChanging(int value);
    partial void OnmadonChanged();
    partial void OnmasachChanging(int value);
    partial void OnmasachChanged();
    partial void OnsoluongChanging(System.Nullable<int> value);
    partial void OnsoluongChanged();
    partial void OngiaChanging(System.Nullable<decimal> value);
    partial void OngiaChanged();
    #endregion
		
		public ChiTietDonHang()
		{
			this._DonHang = default(EntityRef<DonHang>);
			this._Sach = default(EntityRef<Sach>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_madon", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int madon
		{
			get
			{
				return this._madon;
			}
			set
			{
				if ((this._madon != value))
				{
					if (this._DonHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmadonChanging(value);
					this.SendPropertyChanging();
					this._madon = value;
					this.SendPropertyChanged("madon");
					this.OnmadonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_masach", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int masach
		{
			get
			{
				return this._masach;
			}
			set
			{
				if ((this._masach != value))
				{
					if (this._Sach.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmasachChanging(value);
					this.SendPropertyChanging();
					this._masach = value;
					this.SendPropertyChanged("masach");
					this.OnmasachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soluong", DbType="Int")]
		public System.Nullable<int> soluong
		{
			get
			{
				return this._soluong;
			}
			set
			{
				if ((this._soluong != value))
				{
					this.OnsoluongChanging(value);
					this.SendPropertyChanging();
					this._soluong = value;
					this.SendPropertyChanged("soluong");
					this.OnsoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> gia
		{
			get
			{
				return this._gia;
			}
			set
			{
				if ((this._gia != value))
				{
					this.OngiaChanging(value);
					this.SendPropertyChanging();
					this._gia = value;
					this.SendPropertyChanged("gia");
					this.OngiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonHang_ChiTietDonHang", Storage="_DonHang", ThisKey="madon", OtherKey="madon", IsForeignKey=true)]
		public DonHang DonHang
		{
			get
			{
				return this._DonHang.Entity;
			}
			set
			{
				DonHang previousValue = this._DonHang.Entity;
				if (((previousValue != value) 
							|| (this._DonHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DonHang.Entity = null;
						previousValue.ChiTietDonHangs.Remove(this);
					}
					this._DonHang.Entity = value;
					if ((value != null))
					{
						value.ChiTietDonHangs.Add(this);
						this._madon = value.madon;
					}
					else
					{
						this._madon = default(int);
					}
					this.SendPropertyChanged("DonHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sach_ChiTietDonHang", Storage="_Sach", ThisKey="masach", OtherKey="masach", IsForeignKey=true)]
		public Sach Sach
		{
			get
			{
				return this._Sach.Entity;
			}
			set
			{
				Sach previousValue = this._Sach.Entity;
				if (((previousValue != value) 
							|| (this._Sach.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sach.Entity = null;
						previousValue.ChiTietDonHangs.Remove(this);
					}
					this._Sach.Entity = value;
					if ((value != null))
					{
						value.ChiTietDonHangs.Add(this);
						this._masach = value.masach;
					}
					else
					{
						this._masach = default(int);
					}
					this.SendPropertyChanged("Sach");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DonHang")]
	public partial class DonHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _madon;
		
		private System.Nullable<bool> _thanhtoan;
		
		private System.Nullable<bool> _giaohang;
		
		private System.Nullable<System.DateTime> _ngaydat;
		
		private System.Nullable<System.DateTime> _ngaygiao;
		
		private System.Nullable<int> _makh;
		
		private EntitySet<ChiTietDonHang> _ChiTietDonHangs;
		
		private EntityRef<KhachHang> _KhachHang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmadonChanging(int value);
    partial void OnmadonChanged();
    partial void OnthanhtoanChanging(System.Nullable<bool> value);
    partial void OnthanhtoanChanged();
    partial void OngiaohangChanging(System.Nullable<bool> value);
    partial void OngiaohangChanged();
    partial void OnngaydatChanging(System.Nullable<System.DateTime> value);
    partial void OnngaydatChanged();
    partial void OnngaygiaoChanging(System.Nullable<System.DateTime> value);
    partial void OnngaygiaoChanged();
    partial void OnmakhChanging(System.Nullable<int> value);
    partial void OnmakhChanged();
    #endregion
		
		public DonHang()
		{
			this._ChiTietDonHangs = new EntitySet<ChiTietDonHang>(new Action<ChiTietDonHang>(this.attach_ChiTietDonHangs), new Action<ChiTietDonHang>(this.detach_ChiTietDonHangs));
			this._KhachHang = default(EntityRef<KhachHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_madon", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int madon
		{
			get
			{
				return this._madon;
			}
			set
			{
				if ((this._madon != value))
				{
					this.OnmadonChanging(value);
					this.SendPropertyChanging();
					this._madon = value;
					this.SendPropertyChanged("madon");
					this.OnmadonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_thanhtoan", DbType="Bit")]
		public System.Nullable<bool> thanhtoan
		{
			get
			{
				return this._thanhtoan;
			}
			set
			{
				if ((this._thanhtoan != value))
				{
					this.OnthanhtoanChanging(value);
					this.SendPropertyChanging();
					this._thanhtoan = value;
					this.SendPropertyChanged("thanhtoan");
					this.OnthanhtoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_giaohang", DbType="Bit")]
		public System.Nullable<bool> giaohang
		{
			get
			{
				return this._giaohang;
			}
			set
			{
				if ((this._giaohang != value))
				{
					this.OngiaohangChanging(value);
					this.SendPropertyChanging();
					this._giaohang = value;
					this.SendPropertyChanged("giaohang");
					this.OngiaohangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaydat", DbType="Date")]
		public System.Nullable<System.DateTime> ngaydat
		{
			get
			{
				return this._ngaydat;
			}
			set
			{
				if ((this._ngaydat != value))
				{
					this.OnngaydatChanging(value);
					this.SendPropertyChanging();
					this._ngaydat = value;
					this.SendPropertyChanged("ngaydat");
					this.OnngaydatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaygiao", DbType="Date")]
		public System.Nullable<System.DateTime> ngaygiao
		{
			get
			{
				return this._ngaygiao;
			}
			set
			{
				if ((this._ngaygiao != value))
				{
					this.OnngaygiaoChanging(value);
					this.SendPropertyChanging();
					this._ngaygiao = value;
					this.SendPropertyChanged("ngaygiao");
					this.OnngaygiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_makh", DbType="Int")]
		public System.Nullable<int> makh
		{
			get
			{
				return this._makh;
			}
			set
			{
				if ((this._makh != value))
				{
					if (this._KhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmakhChanging(value);
					this.SendPropertyChanging();
					this._makh = value;
					this.SendPropertyChanged("makh");
					this.OnmakhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonHang_ChiTietDonHang", Storage="_ChiTietDonHangs", ThisKey="madon", OtherKey="madon")]
		public EntitySet<ChiTietDonHang> ChiTietDonHangs
		{
			get
			{
				return this._ChiTietDonHangs;
			}
			set
			{
				this._ChiTietDonHangs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_DonHang", Storage="_KhachHang", ThisKey="makh", OtherKey="makh", IsForeignKey=true)]
		public KhachHang KhachHang
		{
			get
			{
				return this._KhachHang.Entity;
			}
			set
			{
				KhachHang previousValue = this._KhachHang.Entity;
				if (((previousValue != value) 
							|| (this._KhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhachHang.Entity = null;
						previousValue.DonHangs.Remove(this);
					}
					this._KhachHang.Entity = value;
					if ((value != null))
					{
						value.DonHangs.Add(this);
						this._makh = value.makh;
					}
					else
					{
						this._makh = default(Nullable<int>);
					}
					this.SendPropertyChanged("KhachHang");
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
		
		private void attach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.DonHang = this;
		}
		
		private void detach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.DonHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _makh;
		
		private string _hoten;
		
		private string _tendangnhap;
		
		private string _matkhau;
		
		private string _email;
		
		private string _diachi;
		
		private string _dienthoai;
		
		private System.Nullable<System.DateTime> _ngaysinh;
		
		private EntitySet<DonHang> _DonHangs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmakhChanging(int value);
    partial void OnmakhChanged();
    partial void OnhotenChanging(string value);
    partial void OnhotenChanged();
    partial void OntendangnhapChanging(string value);
    partial void OntendangnhapChanged();
    partial void OnmatkhauChanging(string value);
    partial void OnmatkhauChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OndiachiChanging(string value);
    partial void OndiachiChanged();
    partial void OndienthoaiChanging(string value);
    partial void OndienthoaiChanged();
    partial void OnngaysinhChanging(System.Nullable<System.DateTime> value);
    partial void OnngaysinhChanged();
    #endregion
		
		public KhachHang()
		{
			this._DonHangs = new EntitySet<DonHang>(new Action<DonHang>(this.attach_DonHangs), new Action<DonHang>(this.detach_DonHangs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_makh", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int makh
		{
			get
			{
				return this._makh;
			}
			set
			{
				if ((this._makh != value))
				{
					this.OnmakhChanging(value);
					this.SendPropertyChanging();
					this._makh = value;
					this.SendPropertyChanged("makh");
					this.OnmakhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hoten", DbType="NVarChar(50)")]
		public string hoten
		{
			get
			{
				return this._hoten;
			}
			set
			{
				if ((this._hoten != value))
				{
					this.OnhotenChanging(value);
					this.SendPropertyChanging();
					this._hoten = value;
					this.SendPropertyChanged("hoten");
					this.OnhotenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tendangnhap", DbType="VarChar(20)")]
		public string tendangnhap
		{
			get
			{
				return this._tendangnhap;
			}
			set
			{
				if ((this._tendangnhap != value))
				{
					this.OntendangnhapChanging(value);
					this.SendPropertyChanging();
					this._tendangnhap = value;
					this.SendPropertyChanged("tendangnhap");
					this.OntendangnhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matkhau", DbType="VarChar(10)")]
		public string matkhau
		{
			get
			{
				return this._matkhau;
			}
			set
			{
				if ((this._matkhau != value))
				{
					this.OnmatkhauChanging(value);
					this.SendPropertyChanging();
					this._matkhau = value;
					this.SendPropertyChanged("matkhau");
					this.OnmatkhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diachi", DbType="NVarChar(100)")]
		public string diachi
		{
			get
			{
				return this._diachi;
			}
			set
			{
				if ((this._diachi != value))
				{
					this.OndiachiChanging(value);
					this.SendPropertyChanging();
					this._diachi = value;
					this.SendPropertyChanged("diachi");
					this.OndiachiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dienthoai", DbType="VarChar(15)")]
		public string dienthoai
		{
			get
			{
				return this._dienthoai;
			}
			set
			{
				if ((this._dienthoai != value))
				{
					this.OndienthoaiChanging(value);
					this.SendPropertyChanging();
					this._dienthoai = value;
					this.SendPropertyChanged("dienthoai");
					this.OndienthoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaysinh", DbType="Date")]
		public System.Nullable<System.DateTime> ngaysinh
		{
			get
			{
				return this._ngaysinh;
			}
			set
			{
				if ((this._ngaysinh != value))
				{
					this.OnngaysinhChanging(value);
					this.SendPropertyChanging();
					this._ngaysinh = value;
					this.SendPropertyChanged("ngaysinh");
					this.OnngaysinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_DonHang", Storage="_DonHangs", ThisKey="makh", OtherKey="makh")]
		public EntitySet<DonHang> DonHangs
		{
			get
			{
				return this._DonHangs;
			}
			set
			{
				this._DonHangs.Assign(value);
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
		
		private void attach_DonHangs(DonHang entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = this;
		}
		
		private void detach_DonHangs(DonHang entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sach")]
	public partial class Sach : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _masach;
		
		private System.Nullable<int> _maloai;
		
		private string _tensach;
		
		private string _hinh;
		
		private System.Nullable<decimal> _giaban;
		
		private System.Nullable<System.DateTime> _ngaycapnhat;
		
		private System.Nullable<int> _soluongton;
		
		private EntitySet<ChiTietDonHang> _ChiTietDonHangs;
		
		private EntityRef<TheLoai> _TheLoai;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmasachChanging(int value);
    partial void OnmasachChanged();
    partial void OnmaloaiChanging(System.Nullable<int> value);
    partial void OnmaloaiChanged();
    partial void OntensachChanging(string value);
    partial void OntensachChanged();
    partial void OnhinhChanging(string value);
    partial void OnhinhChanged();
    partial void OngiabanChanging(System.Nullable<decimal> value);
    partial void OngiabanChanged();
    partial void OnngaycapnhatChanging(System.Nullable<System.DateTime> value);
    partial void OnngaycapnhatChanged();
    partial void OnsoluongtonChanging(System.Nullable<int> value);
    partial void OnsoluongtonChanged();
    #endregion
		
		public Sach()
		{
			this._ChiTietDonHangs = new EntitySet<ChiTietDonHang>(new Action<ChiTietDonHang>(this.attach_ChiTietDonHangs), new Action<ChiTietDonHang>(this.detach_ChiTietDonHangs));
			this._TheLoai = default(EntityRef<TheLoai>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_masach", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int masach
		{
			get
			{
				return this._masach;
			}
			set
			{
				if ((this._masach != value))
				{
					this.OnmasachChanging(value);
					this.SendPropertyChanging();
					this._masach = value;
					this.SendPropertyChanged("masach");
					this.OnmasachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maloai", DbType="Int")]
		public System.Nullable<int> maloai
		{
			get
			{
				return this._maloai;
			}
			set
			{
				if ((this._maloai != value))
				{
					if (this._TheLoai.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaloaiChanging(value);
					this.SendPropertyChanging();
					this._maloai = value;
					this.SendPropertyChanged("maloai");
					this.OnmaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tensach", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string tensach
		{
			get
			{
				return this._tensach;
			}
			set
			{
				if ((this._tensach != value))
				{
					this.OntensachChanging(value);
					this.SendPropertyChanging();
					this._tensach = value;
					this.SendPropertyChanged("tensach");
					this.OntensachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinh", DbType="VarChar(50)")]
		public string hinh
		{
			get
			{
				return this._hinh;
			}
			set
			{
				if ((this._hinh != value))
				{
					this.OnhinhChanging(value);
					this.SendPropertyChanging();
					this._hinh = value;
					this.SendPropertyChanged("hinh");
					this.OnhinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_giaban", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> giaban
		{
			get
			{
				return this._giaban;
			}
			set
			{
				if ((this._giaban != value))
				{
					this.OngiabanChanging(value);
					this.SendPropertyChanging();
					this._giaban = value;
					this.SendPropertyChanged("giaban");
					this.OngiabanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaycapnhat", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> ngaycapnhat
		{
			get
			{
				return this._ngaycapnhat;
			}
			set
			{
				if ((this._ngaycapnhat != value))
				{
					this.OnngaycapnhatChanging(value);
					this.SendPropertyChanging();
					this._ngaycapnhat = value;
					this.SendPropertyChanged("ngaycapnhat");
					this.OnngaycapnhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soluongton", DbType="Int")]
		public System.Nullable<int> soluongton
		{
			get
			{
				return this._soluongton;
			}
			set
			{
				if ((this._soluongton != value))
				{
					this.OnsoluongtonChanging(value);
					this.SendPropertyChanging();
					this._soluongton = value;
					this.SendPropertyChanged("soluongton");
					this.OnsoluongtonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sach_ChiTietDonHang", Storage="_ChiTietDonHangs", ThisKey="masach", OtherKey="masach")]
		public EntitySet<ChiTietDonHang> ChiTietDonHangs
		{
			get
			{
				return this._ChiTietDonHangs;
			}
			set
			{
				this._ChiTietDonHangs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TheLoai_Sach", Storage="_TheLoai", ThisKey="maloai", OtherKey="maloai", IsForeignKey=true)]
		public TheLoai TheLoai
		{
			get
			{
				return this._TheLoai.Entity;
			}
			set
			{
				TheLoai previousValue = this._TheLoai.Entity;
				if (((previousValue != value) 
							|| (this._TheLoai.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TheLoai.Entity = null;
						previousValue.Saches.Remove(this);
					}
					this._TheLoai.Entity = value;
					if ((value != null))
					{
						value.Saches.Add(this);
						this._maloai = value.maloai;
					}
					else
					{
						this._maloai = default(Nullable<int>);
					}
					this.SendPropertyChanged("TheLoai");
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
		
		private void attach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.Sach = this;
		}
		
		private void detach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.Sach = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TheLoai")]
	public partial class TheLoai : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _maloai;
		
		private string _tenloai;
		
		private EntitySet<Sach> _Saches;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaloaiChanging(int value);
    partial void OnmaloaiChanged();
    partial void OntenloaiChanging(string value);
    partial void OntenloaiChanged();
    #endregion
		
		public TheLoai()
		{
			this._Saches = new EntitySet<Sach>(new Action<Sach>(this.attach_Saches), new Action<Sach>(this.detach_Saches));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maloai", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int maloai
		{
			get
			{
				return this._maloai;
			}
			set
			{
				if ((this._maloai != value))
				{
					this.OnmaloaiChanging(value);
					this.SendPropertyChanging();
					this._maloai = value;
					this.SendPropertyChanged("maloai");
					this.OnmaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenloai", DbType="NVarChar(30)")]
		public string tenloai
		{
			get
			{
				return this._tenloai;
			}
			set
			{
				if ((this._tenloai != value))
				{
					this.OntenloaiChanging(value);
					this.SendPropertyChanging();
					this._tenloai = value;
					this.SendPropertyChanged("tenloai");
					this.OntenloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TheLoai_Sach", Storage="_Saches", ThisKey="maloai", OtherKey="maloai")]
		public EntitySet<Sach> Saches
		{
			get
			{
				return this._Saches;
			}
			set
			{
				this._Saches.Assign(value);
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
		
		private void attach_Saches(Sach entity)
		{
			this.SendPropertyChanging();
			entity.TheLoai = this;
		}
		
		private void detach_Saches(Sach entity)
		{
			this.SendPropertyChanging();
			entity.TheLoai = null;
		}
	}
}
#pragma warning restore 1591

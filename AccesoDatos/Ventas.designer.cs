﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SAP_DB")]
	public partial class VentasDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public VentasDataContext() : 
				base(global::AccesoDatos.Properties.Settings.Default.SAP_DBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public VentasDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VentasDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VentasDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VentasDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ConsultaVentas")]
		public ISingleResult<sp_ConsultaVentasResult> sp_ConsultaVentas()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_ConsultaVentasResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_EliminarVenta")]
		public int sp_EliminarVenta([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_InsertarVenta")]
		public int sp_InsertarVenta([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fac", DbType="Int")] System.Nullable<int> fac, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cliente", DbType="Int")] System.Nullable<int> cliente, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Sub", DbType="Decimal(18,2)")] System.Nullable<decimal> sub, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IVA", DbType="Decimal(18,2)")] System.Nullable<decimal> iVA, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Total", DbType="Decimal(18,2)")] System.Nullable<decimal> total, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fecha", DbType="DateTime")] System.Nullable<System.DateTime> fecha)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fac, cliente, sub, iVA, total, fecha);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_EliminaVentasCliente")]
		public int sp_EliminaVentasCliente([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class sp_ConsultaVentasResult
	{
		
		private int _Id_Ventas;
		
		private int _Factura;
		
		private int _Cliente;
		
		private System.Nullable<decimal> _SubTotal;
		
		private System.Nullable<decimal> _IVA;
		
		private System.Nullable<decimal> _Total;
		
		private System.DateTime _Fecha;
		
		public sp_ConsultaVentasResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Ventas", DbType="Int NOT NULL")]
		public int Id_Ventas
		{
			get
			{
				return this._Id_Ventas;
			}
			set
			{
				if ((this._Id_Ventas != value))
				{
					this._Id_Ventas = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Factura", DbType="Int NOT NULL")]
		public int Factura
		{
			get
			{
				return this._Factura;
			}
			set
			{
				if ((this._Factura != value))
				{
					this._Factura = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cliente", DbType="Int NOT NULL")]
		public int Cliente
		{
			get
			{
				return this._Cliente;
			}
			set
			{
				if ((this._Cliente != value))
				{
					this._Cliente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubTotal", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> SubTotal
		{
			get
			{
				return this._SubTotal;
			}
			set
			{
				if ((this._SubTotal != value))
				{
					this._SubTotal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IVA", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> IVA
		{
			get
			{
				return this._IVA;
			}
			set
			{
				if ((this._IVA != value))
				{
					this._IVA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Total
		{
			get
			{
				return this._Total;
			}
			set
			{
				if ((this._Total != value))
				{
					this._Total = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="DateTime NOT NULL")]
		public System.DateTime Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this._Fecha = value;
				}
			}
		}
	}
}
#pragma warning restore 1591

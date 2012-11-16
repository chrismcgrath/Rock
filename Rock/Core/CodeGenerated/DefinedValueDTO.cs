//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Serialization;

using Rock.Data;

namespace Rock.Core
{
    /// <summary>
    /// Data Transfer Object for DefinedValue object
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class DefinedValueDto : IDto, DotLiquid.ILiquidizable
    {
        /// <summary />
        [DataMember]
        public bool IsSystem { get; set; }

        /// <summary />
        [DataMember]
        public int DefinedTypeId { get; set; }

        /// <summary />
        [DataMember]
        public int Order { get; set; }

        /// <summary />
        [DataMember]
        public string Name { get; set; }

        /// <summary />
        [DataMember]
        public string Description { get; set; }

        /// <summary />
        [DataMember]
        public int Id { get; set; }

        /// <summary />
        [DataMember]
        public Guid Guid { get; set; }

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public DefinedValueDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="definedValue"></param>
        public DefinedValueDto ( DefinedValue definedValue )
        {
            CopyFromModel( definedValue );
        }

        /// <summary>
        /// Creates a dictionary object.
        /// </summary>
        /// <returns></returns>
        public virtual Dictionary<string, object> ToDictionary()
        {
            var dictionary = new Dictionary<string, object>();
            dictionary.Add( "IsSystem", this.IsSystem );
            dictionary.Add( "DefinedTypeId", this.DefinedTypeId );
            dictionary.Add( "Order", this.Order );
            dictionary.Add( "Name", this.Name );
            dictionary.Add( "Description", this.Description );
            dictionary.Add( "Id", this.Id );
            dictionary.Add( "Guid", this.Guid );
            return dictionary;
        }

        /// <summary>
        /// Creates a dynamic object.
        /// </summary>
        /// <returns></returns>
        public virtual dynamic ToDynamic()
        {
            dynamic expando = new ExpandoObject();
            expando.IsSystem = this.IsSystem;
            expando.DefinedTypeId = this.DefinedTypeId;
            expando.Order = this.Order;
            expando.Name = this.Name;
            expando.Description = this.Description;
            expando.Id = this.Id;
            expando.Guid = this.Guid;
            return expando;
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyFromModel( IEntity model )
        {
            if ( model is DefinedValue )
            {
                var definedValue = (DefinedValue)model;
                this.IsSystem = definedValue.IsSystem;
                this.DefinedTypeId = definedValue.DefinedTypeId;
                this.Order = definedValue.Order;
                this.Name = definedValue.Name;
                this.Description = definedValue.Description;
                this.Id = definedValue.Id;
                this.Guid = definedValue.Guid;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyToModel ( IEntity model )
        {
            if ( model is DefinedValue )
            {
                var definedValue = (DefinedValue)model;
                definedValue.IsSystem = this.IsSystem;
                definedValue.DefinedTypeId = this.DefinedTypeId;
                definedValue.Order = this.Order;
                definedValue.Name = this.Name;
                definedValue.Description = this.Description;
                definedValue.Id = this.Id;
                definedValue.Guid = this.Guid;
            }
        }

        /// <summary>
        /// Converts to liquidizable object for dotLiquid templating
        /// </summary>
        /// <returns></returns>
        public object ToLiquid()
        {
            return this.ToDictionary();
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public static class DefinedValueDtoExtension
    {
        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static DefinedValue ToModel( this DefinedValueDto value )
        {
            DefinedValue result = new DefinedValue();
            value.CopyToModel( result );
            return result;
        }

        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<DefinedValue> ToModel( this List<DefinedValueDto> value )
        {
            List<DefinedValue> result = new List<DefinedValue>();
            value.ForEach( a => result.Add( a.ToModel() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<DefinedValueDto> ToDto( this List<DefinedValue> value )
        {
            List<DefinedValueDto> result = new List<DefinedValueDto>();
            value.ForEach( a => result.Add( a.ToDto() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static DefinedValueDto ToDto( this DefinedValue value )
        {
            return new DefinedValueDto( value );
        }

    }
}
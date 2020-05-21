using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace TooSharp.Models
{   
    /// <summary>
    ///  TooSharp Generated Code. Do not Modify 
    ///  Date Genereated: 20/05/2020 12:41 AM
    ///  Author: chien
    /// </summary>
    /// <seealso cref="TooSharp.Core.ITSRelationShips" />
    [DebuggerStepThrough]
    public class Configurations : TooSharp.Core.ITSModel
    {
      #region CODE
	     public static string TableName = "configuration";
         public string GetTableName() { return TableName; }
         public List<string> GetColumns() {return Enum.GetValues(typeof(COLUMNS)).Cast<COLUMNS>().Select(v => v.ToString()).ToList();  }
         public static TooSharp.Core.TSQueryBuilder<Configuration> Records() { return new TooSharp.Core.TSQueryBuilder<Configuration>(TooSharp.TSRelationships.getInstance()); }
         public static TooSharp.Core.TSQueryBuilder<Configuration> Records(object[] columns) { return new TooSharp.Core.TSQueryBuilder<Configuration>(TooSharp.TSRelationships.getInstance(),columns); }
      #endregion
      #region COLUMNS
       public enum COLUMNS
       {
         configurationcol,
         id,
         test1,
         test2,
         test3,
         test4,
         //column
       }
      #endregion
    }
     [DebuggerStepThrough]
    public class Configuration: TooSharp.Core.TSmodel 
    {
     
       #region PROPERTIES
         [TSKey]
         public string Configurationcol { get; private set; }= string.Empty;
         public int Id { get; set; }
         public string Test1 { get; set; }
         public int Test2 { get; set; }
         public string Test3 { get; set; }
         public string Test4 { get; set; }
         //property
       #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobTracking.Core
{
    public enum ConditionType
    {
        /// <summary>
        /// Two values are equal
        /// </summary>
        [Display(Name = "Eşit")]
        Equal = 0,

        /// <summary>
        /// Value is greater then variable
        /// </summary>
        [Display(Name = "Büyük")]
        GreaterThan = 1,

        /// <summary>
        /// Value is less then variable
        /// </summary>
        [Display(Name = "Küçük")]
        LessThan = 2,

        /// <summary>
        /// Value is greater then variable or equals to it
        /// </summary>
        [Display(Name = "Büyük Eşit")]
        GreaterThanOrEqual = 3,

        /// <summary>
        /// Value is less then variable or equals to it
        /// </summary>
        [Display(Name = "Küçük Eşit")]
        LessThanOrEqual = 4,

        /// <summary>
        /// Value is false
        /// </summary>
        [Display(Name = "Hayır")]
        IsFalse = 5,

        /// <summary>
        /// Value is true
        /// </summary>
        [Display(Name = "Evet")]
        IsTrue = 6,

        /// <summary>
        /// Value is not equal to column value
        /// </summary>
        [Display(Name = "Eşit Değil")]
        NotEqual = 7,

        /// <summary>
        /// Column value starts with value
        /// </summary>
        [Display(Name = "Başlayan")]
        StartsWith = 8,

        /// <summary>
        /// Columns value ends with given value
        /// </summary>
        [Display(Name = "Biten")]
        EndsWith = 9,

        /// <summary>
        /// Columns value contains given value
        /// </summary>
        [Display(Name = "İçeren")]
        Contains = 10,
        /// <summary>
        /// Columns value contains given value
        /// </summary>
        [Display(Name = "Arasında")]
        Range = 11,

        [Display(Name = "Bunu İçermeyen")]
        NotContains = 11
    }
}

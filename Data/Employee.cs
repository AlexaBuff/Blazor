using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public class Employee
    {
        [Key]      
        public Int64 IdEmp { get; set; }

        //[MaxLength(30)]
        [StringLength(30, ErrorMessage ="В поле вводится не более 30 символов.")]
        public string FEmp { get; set; }
       
        //[MaxLength(20)]
        [StringLength(20, ErrorMessage = "В поле вводится не более 20 символов.")]
        public string IEmp { get; set; }
        
        //[MaxLength(20)]
        [StringLength(20, ErrorMessage = "В поле вводится не более 20 символов.")]
        public string OEmp { get; set; }

        [MaxLength(1)]
        public string PolEmp { get; set; }

        public DateTime? DRozhEmp { get; set; }

        //[MaxLength(10)]
        //[StringLength(20, ErrorMessage = "В поле вводится не более 20 символов.")]
        [RegularExpression(@"^\(?\d{3}?\)??-??\(?\d{3}?\)??-??\(?\d{4}?\)??-?$", ErrorMessage = "В поле вводится телефон в формате XXX-XXX-XXXX")]
        public string TelEmp { get; set; }

        //[MaxLength(255)]
        [StringLength(255, ErrorMessage = "В поле вводится не более 255 символов.")]        
       
        public string AdressEmp { get; set; }

        //[MaxLength(4)]
        //[StringLength(4, MinimumLength = 4, ErrorMessage = "В поле вводится 4 цифры.")]     
        //[RegularExpression("[0-9]{4}", ErrorMessage = "В поле вводятся 4 цифры.")]
        public string PassportSEmp { get; set; }

        //[MaxLength(6)]
        //[StringLength(6, ErrorMessage = "В поле вводится не более 6 символов.")]
        [RegularExpression(@"\s*[0-9]{6}\s*", ErrorMessage = "В поле вводятся 6 цифр.")]
        public string PassportNEmp { get; set; }

        public DateTime? PassportDEmp { get; set; }

        //[MaxLength(100)]
        [StringLength(100, ErrorMessage = "В поле вводится не более 100 символов.")]
        public string PassportVEmp { get; set; }

        //[MaxLength(20)]
        //[StringLength(16, ErrorMessage = "В поле вводится не более 16 символов.")]
        [RegularExpression(@"\s*[0-9]{16}\s*", ErrorMessage = "В поле вводятся 16 цифр.")]
        public string PolisEmp { get; set; }


    }
}

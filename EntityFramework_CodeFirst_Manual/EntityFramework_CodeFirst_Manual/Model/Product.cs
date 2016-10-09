using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_CodeFirst_Manual.Model
{
    //註解,指定對映LProduct Table名稱
    [Table("LProduct")]
    public class Product
    {
        //註解,標示主索引鍵欄位
        [Key]
        public int Id { get; set; }//產品id

        //註解,標示必要性欄位
        [Required]
        //註解,標示指定ProductName欄位名稱
        [Column("ProductName")]
        //註解,欄位長度最大50、最小2
        //[MaxLength(50), MinLength(2)]
        //↓↓↓↓可以增加錯誤訊息↓↓↓↓
        [MaxLength(50,ErrorMessage = "ProductName欄位資料長度不得大於50"),MinLength(2)]
        //註解,標示建立索引,並索引是唯一值
        //[Index("ProductNameIndex", IsUnique = true)]
        //↓↓↓↓多索引時,指定優先權↓↓↓↓
        [Index("ProductNameIndex", 2, IsUnique = true)]
        public string Name { get; set; }//產品名稱

        //註解,標示指定ListPrice欄位名稱以及欄位Money型態
        [Column("ListPrice", TypeName ="Money")]
        public int Price { get; set; }//產品單價
        
        //註解,標示建立索引
        //[Index]
        //↓↓↓↓索引可以增加建立的索引名稱↓↓↓↓
        //[Index("CategoryIndex")]
        //↓↓↓↓多索引時,指定優先權↓↓↓↓
        [Index("CategoryIndex", 1)]
        public int Category { get; set; }//產品類別

        //註解,標示不需要對映Table欄位
        [NotMapped]
        public decimal SPrice { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FileLoader.Models
{
    [Table("files")]
    public class FileModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required] //Not null
        [Column("original_name")]
        public string OriginalName { get; set; }

        [Required] //Not null
        [Column("storage_name")]
        public string StorageName { get; set; }

        [Required]//Not null
        [Column("path")]
        public string Path { get; set; }

        [Required]//Not null
        [Column("full_link")]
        public string FullLink { get; set; }

        [Required]//Not null
        [Column("gen_part_of_link")]
        public string GeneratedPartOfLink { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace spms.Models;

[Table("Admin")]// if we donot use the DataAnnotations schema 
//this gives a compile time error for this Attribute
public class Admin{
    [Key]// if wee donot use the Dataannotations this will give a compile time error
   // [Column("user_name")]
    public string UserName{get; set;}

    public string Name{get; set;}
    public string Password{get; set;}

    public string Email{get; set;}
}
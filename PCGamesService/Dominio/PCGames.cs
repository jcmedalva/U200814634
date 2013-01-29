using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PCGamesService.Dominio
{
    [DataContract]
    [Table("PCGames")]
    public class PCGames
    {

        public PCGames()
        {
        }

        public PCGames(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }

        private int _codigo;
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.DatabaseGeneratedOption.None)]
        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _nombre;
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


    }
}
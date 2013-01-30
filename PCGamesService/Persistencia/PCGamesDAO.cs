using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PCGamesService.Dominio;
using Persistencia.EF;
using System.ServiceModel;

namespace PCGamesService.Persistencia
{
    public class PCGamesDAO
    {

        public void registrarPCGame(PCGames PCGames)
        {
            using (EFContext db = new EFContext(ConexionUtil.obtenerCadena()))
            {
                try
                {
                    db.PCGames.Add(PCGames);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    var operationFault = new InvalidOperationFault { Message = "No se puede ingresar un duplicado" };
                    throw new FaultException<InvalidOperationFault>(operationFault);
                }
            }
        }

        public List<PCGamesEntity.PCGames> listarPCGames()
        { 
            using (EFContext db = new EFContext(ConexionUtil.obtenerCadena()))
            {
                var resultado = from l in db.PCGames
                                select l;

                var ListaCC = new List<PCGamesEntity.PCGames>();
                foreach (var item in resultado)
                {
                    var newItem = new PCGamesEntity.PCGames();
                    newItem.codigo = item.codigo;
                    newItem.nombre = item.nombre;
                    ListaCC.Add(newItem);
                }

                return ListaCC;
            }
        }
    }
}
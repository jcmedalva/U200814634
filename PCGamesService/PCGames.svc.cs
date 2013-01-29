using System;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PCGamesService.Dominio;
using PCGamesService.Persistencia;

namespace PCGamesService
{
    public class ConfigCentroCosto : IPCGames
    {

        void IPCGames.registrarPCGame(int codigo, string descripcion)
        {
            PCGames cc = new PCGames(codigo, descripcion);
            PCGamesDAO ccDAO = new PCGamesDAO();
            ccDAO.registrarPCGame(cc);
        }

        List<PCGamesEntity.PCGames> IPCGames.listarPCGame()
        {
            PCGamesDAO ccDAO = new PCGamesDAO();
            var result = ccDAO.listarPCGames();
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PCGamesService.Dominio;

namespace PCGamesService
{
    [ServiceContract]
    public interface IPCGames
    {

        [OperationContract]
        void registrarPCGame(int codigo, string descripcion);

        [OperationContract]
        List<PCGamesEntity.PCGames> listarPCGame();

    }
}

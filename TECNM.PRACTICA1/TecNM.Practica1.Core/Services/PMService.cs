using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Services;

public class PMService : IPMService
{
    public PM ProcessPM(User user){
        var pm = new PM();
        pm.index = (float)((user.Weight / user.GravityE) * user.GravityM);
    
    return pm;
    }
}
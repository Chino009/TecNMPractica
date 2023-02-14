using TecNM.Practica1.Core.Managers.Interfaces;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Managers;

public class PMManagers : IPMManager
{
    private readonly IPMService _service;
    public PMManagers (IPMService service){
        _service = service;
    }

    public PM GetPM(User user){
        return _service.ProcessPM(user);
    }
}

using TecNM.Practica1.Core.Entities;

namespace TecNM.Practica1.Core.Managers.Interfaces;

public interface IPMManager
{
    PM GetPM(User user);
}
using System;

public class guaradarEnBD
{
    public void guardarEnDB()
    {
        TransporteRepository repository = new TransporteRepository();
        repository.guardar(this);
    }

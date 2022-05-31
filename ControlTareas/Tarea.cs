class Tarea
{
    int tareaID, duracion;
    string descripcion;

    public int TareaID { get => tareaID; set => tareaID = value; }
    public int Duracion { get => duracion; set => duracion = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }

    public Tarea(int id, int dura, string desc){
        tareaID = id;
        duracion = dura;
        descripcion = desc;
    }

    public Tarea(){
    }
}
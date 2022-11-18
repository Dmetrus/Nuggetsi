namespace BibliotekaSamolet
{
    public class Class1<T> where T : class
    {
        private List<T> Planes = new List<T>();

        public List<T> GetAll()
        {
            return Planes;
        }

        public void AddPlanes(T planes)
        {
            Planes.Add(planes);
        }

        public void DeletePlanes(T planes)
        {
            Planes.Remove(planes);
        }

        public void ChangePlanes(int index, T planes)
        {
            Planes[index] = planes;
        }
    }
}
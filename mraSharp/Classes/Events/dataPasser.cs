using mraNet.Forms;

namespace mraNet.Classes.Events
{
    internal class DataPasser
    {
        public DataPasser(ApplicationWindow form, string filepath)
        {
            Form = form;
            FilePath = filepath;
        }

        public ApplicationWindow Form { get; set; }

        public string FilePath { get; set; }
    }
}
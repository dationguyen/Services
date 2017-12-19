using Microsoft.Azure.Mobile.Server;

namespace TFWGService.DataObjects
{
    public class Session:EntityData
    {
        public string Name { get; set; }

        public bool Status { get; set; }
    }
}
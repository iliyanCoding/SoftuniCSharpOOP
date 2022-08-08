using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    public class Robot : IIdentifiable
    {
        public Robot(string id)
        {
            this.Id = id;
        }
        public string Model { get; private set; }
        public string Id { get; private set; }
    }
}

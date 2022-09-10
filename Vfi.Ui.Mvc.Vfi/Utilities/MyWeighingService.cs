using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Utilities {
    public class MyWeighingService {
        public class MyWeighingModel {
            public string PortName { get; set; }
            public int BaudRate { get; set; }
            public int SignalType { get; set; }
        }

        public static MyWeighingModel GetConfig() {
            var fileName = "weighingvalue.json";
            var destinationPath = Path.Combine(MyUtilities.MySystem.GetUtilityPath(), fileName);
            var file = File.ReadAllText(destinationPath);
            var model = JsonConvert.DeserializeObject<MyWeighingModel>(file);
            return model;
        }
    }
}
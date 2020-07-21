using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAndJumpLib.Models {
    public class LevelModel {
        public LevelModel() { }
        //public LevelModel(RunAndJumpDbEntities db, Levels level) {
        //    this.LevelName = level.LevelName;
        //    this.MaxCoins = level.MaxCoins ?? 0;
        //    this.LevelId = level.LevelId;
        //}
        public string LevelName { get; set; }
        public int LevelId { get; set; }
        public int MaxCoins { get; set; }
    }
}

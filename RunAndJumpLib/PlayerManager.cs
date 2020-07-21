using RunAndJumpLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAndJumpLib {
    public static class PlayerManager {
        public static LevelModel LevelInfo(string name) {
            try {
                //using (var db = new RunAndJumpDbEntities()) {
                //    var level = db.Levels.FirstOrDefault();
                //    if (level == null)
                //        return new LevelModel() {
                //            MaxCoins = 100
                //        };
                //    return new LevelModel(db, level);
                // }
                return null;
            } catch (Exception ex) {
                return null;
            }
        }

        public static bool CreateNewPlayer() {
            try {

            } catch (Exception ex) {

            }
            return true;
        }
    }
}

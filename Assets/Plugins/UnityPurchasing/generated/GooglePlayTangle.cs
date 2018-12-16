#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("d8ortSiy4QFhY5EuCPVIzj5lHv6UbrN+nkzRSVszZIVh9tJ8RMhnwH9INY1xSf8h+DuocP3kUbhPiQK+M7W5zgln5wVMCjt4IZGKXYAn03t+/fP8zH799v5+/f38KjCMNh9hOfr11nq0egvx/f39+fz/fv3z/Mx+SwP63Jqcf0g1jXFJ/yH4O6hw/eRRWadXKLhInjUe2P8AiOelpn4ORlKdZMkI6rhFdP7Sp9Es6lLJ1xHAfWF/ore7f4c4DhH128XBvX7T8nBRuE+JAr59YX+it7t/hzgOEfXbxSyMvi68vD9RPn23xZRuM7W5zgln/L0Bov8UmhcNe9F32HvUR1UTA+ie/9hEjcVNNSyGkZ+7rEsD+tyanGkaSqcqB04pCqAPCrC13z6pbKlbuEV0/tKn0SzqUsnXEcBpGkqnKgdOKQqgDwqwtd8+qWypW4IEmJfH0MG9ftPycCV9af7//fz9zH793szxujfks3x+nv/YRI3FTTUshpGfu6wTXhqlb83/mKXTyNGie1KdZMkI6sx+/d7M8fr11nq0egvx/f39+fz/lG1G1LzzE14apW/N/5il08jRonv99v5+/f38KjCMNh9hOfy9AaL/FOelpn4ORpRus36eTNFJWzNkhWH2ggSYl8fQd8ortSiy4QFhY5EuCPXnBUwKO3ghkYpdgCfTe7o35LN8fpoXDXvRd9h71EdVEwPolG1G1Lzz0nxEyGfALIy+Lry8P1E+fbfFlG5Izj5lHv5RWadXKLhInjUe2P8AiCV9af7//fz9");
        private static int[] order = new int[] { 21,23,27,10,23,15,12,22,23,28,13,24,27,26,15,19,20,19,24,24,21,26,26,23,27,25,27,28,28,29 };
        private static int key = 252;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif

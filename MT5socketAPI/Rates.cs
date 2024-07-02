using Newtonsoft.Json;

namespace MTsocketAPI.MT5
{
    public class Rates
    {
        public string TIME { get; set; }
        public double OPEN { get; set; }
        public double HIGH { get; set; }
        public double LOW { get; set; }
        public double CLOSE { get; set; }
        public int TICK_VOLUME { get; set; }
        public int SPREAD { get; set; }
        public int REAL_VOLUME { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}

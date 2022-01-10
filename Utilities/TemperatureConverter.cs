namespace Utilities
{
    public class TemperatureConverter
    {
   
        public float ConvertToC(float tempInF)
        {
            var converted = (tempInF - 32) * .5556F;
            var result = Math.Round(converted, 2);
            return (float) result;
        }
    }
}
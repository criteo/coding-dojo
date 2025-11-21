namespace OpeningHoursEvaluator
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="openingHours">a representation of opening hours that follows the specification https://wiki.openstreetmap.org/wiki/Key:opening_hours, for instance "Mo-Fr 10:00-20:00; Mo-Fr 08:00-21:00;"</param>
    public class OpeningHoursEvaluator(string openingHours)
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns>Whether the date parameter passed matches an opening hours, according to the opening hours passed in the constructor of the class</returns>
        public bool IsOpenAt(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}

package dojo;

import java.util.Calendar;
import java.util.GregorianCalendar;
import java.util.TimeZone;

public class DojoIso8601 {

	public static Calendar toCalendar(String toParse) {
		Calendar cal = new GregorianCalendar();
		// TODO: implement the parser

		// Hints: some useful methods:
		// - cal.set(year, month, day);
		// - cal.set(year, month, day, hourOfDay, minute, second);
		// - cal.set(Calendar.MILLISECOND, ms);
		// - cal.setTimeZone(TimeZone.getTimeZone(...))

		return cal;
	}
}

package com.pluralsight;

import java.time.Duration;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.firefox.FirefoxDriver;
import org.openqa.selenium.support.ui.WebDriverWait;

public class Browser {
	
	private static final long timeOutInSeconds = 1000;
	
	static WebDriver driver = new FirefoxDriver();
	static WebDriverWait wait = new WebDriverWait(driver, timeOutInSeconds);
	
	
	public static void goTo(String url) {
		driver.get(url);
	}

	public static String title() {
		
		return driver.getTitle();
	}	

	public static void close() {
		driver.close();
	}
	
}
	



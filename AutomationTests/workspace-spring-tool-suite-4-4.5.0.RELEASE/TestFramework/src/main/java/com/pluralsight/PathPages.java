package com.pluralsight;

import java.util.concurrent.TimeUnit;

import org.openqa.selenium.By;

public class PathPages {

	static String url = "https://www.pluralsight.com/product/paths";
	static String title = "AngularJS Learning Paths - AngularJS Tutorials | Pluralsight";
	
	public void goTo() {
		Browser.goTo(url);
		
	}
	
	public void goToJavaPath() {
		
		
		Browser.driver.manage().timeouts().implicitlyWait(5000, TimeUnit.SECONDS);
		Browser.driver.findElement(By.cssSelector(".item:nth-child(25) li:nth-child(1)")).click();
		
		
		//Browser.driver.findElement(By.cssSelector(".item:nth-child(176) .item-text")).click();
	    //assertThat(driver.getTitle(), is("Java | Pluralsight"));
		
	}
	
	public boolean isAt() {
		return Browser.title().equals(title);
	}

	
	

}

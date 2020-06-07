using System;

class BrowserHistory{

    class WebPage{
        public string webPageName;
        public WebPage back, forward; 
        public WebPage(string name){
            webPageName = name;
            back = null;
            forward = null;
        }
    }
    WebPage currentPage = null;
    public BrowserHistory(string homepage) {
        currentPage = new WebPage(homepage);
    }
    
    public void Visit(string url) {
        WebPage newPage = new WebPage(url);
        currentPage.forward = newPage;
        newPage.back = currentPage;
        currentPage = newPage;
    }
    
    public string Back(int steps) {
        while(steps>0 && currentPage.back!=null) {
            currentPage = currentPage.back;
            steps--;
        }
        return currentPage.webPageName;
    }
    
    public string Forward(int steps) {
        while(steps>0 && currentPage.forward!=null) {
            currentPage = currentPage.forward;
            steps--;
        }
        return currentPage.webPageName;
    }

    // public static void Main() {
    //     BrowserHistory browserHistory = new BrowserHistory("leetcode.com");
    // browserHistory.Visit("google.com");       // You are in "leetcode.com". Visit "google.com"
    // browserHistory.Visit("facebook.com");     // You are in "google.com". Visit "facebook.com"
    // browserHistory.Visit("youtube.com");      // You are in "facebook.com". Visit "youtube.com"
    // browserHistory.Back(1);                   // You are in "youtube.com", move back to "facebook.com" return "facebook.com"
    // browserHistory.Back(1);                   // You are in "facebook.com", move back to "google.com" return "google.com"
    // browserHistory.Forward(1);                // You are in "google.com", move forward to "facebook.com" return "facebook.com"
    // browserHistory.Visit("linkedin.com");     // You are in "facebook.com". Visit "linkedin.com"
    // browserHistory.Forward(2);                // You are in "linkedin.com", you cannot move forward any steps.
    // browserHistory.Back(2);                   // You are in "linkedin.com", move back two steps to "facebook.com" then to "google.com". return "google.com"
    // browserHistory.Back(7);                   // You are in "google.com", you can move back only one step to "leetcode.com". return "leetcode.com"
    // }
}
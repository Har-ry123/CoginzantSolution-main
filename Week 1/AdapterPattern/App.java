public class App {
    public static void main(String[] args) {

        PayementProcessor razorPayProcessor = new RazorPayAdapter(new RazorPayGateway());
        PayementProcessor ccAvenueProcessor = new CcavenueAdapter(new CcavenueGateway());

        System.out.println("Using RazorPay Adapter:");
        razorPayProcessor.processPayment(1500.00);

        System.out.println("Using CCAvenue Adapter:");
        ccAvenueProcessor.processPayment(2500.50);
    }
}
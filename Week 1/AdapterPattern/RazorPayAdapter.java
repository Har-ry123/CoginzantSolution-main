public class RazorPayAdapter implements PayementProcessor {
    private final RazorPayGateway razorPayGateway;
    
    public RazorPayAdapter(RazorPayGateway razorPayGateway) {
        this.razorPayGateway = razorPayGateway;
    }
    
    @Override
    public void processPayment(double amount) {
        razorPayGateway.processPayment(amount);
    }
}

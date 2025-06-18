public class CcavenueAdapter implements PaymentProcessor {
    private final CcavenueGateway ccAvenueGateway;

    public CcavenueAdapter(CcavenueGateway ccAvenueGateway) {
        this.ccAvenueGateway = ccAvenueGateway;
    }

    @Override
    public void processPayment(double amount) {
        ccAvenueGateway.processPayment(amount);
    }
}

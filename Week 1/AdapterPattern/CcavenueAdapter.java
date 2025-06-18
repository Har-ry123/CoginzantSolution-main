public class CcavenueAdapter implements PayementProcessor {
    private final CcavenueGateway ccAvenueGateway;

    public CcavenueAdapter(CcavenueGateway ccAvenueGateway) {
        this.ccAvenueGateway = ccAvenueGateway;
    }

    @Override
    public void processPayment(double amount) {
        ccAvenueGateway.processPayment(amount);
    }
}

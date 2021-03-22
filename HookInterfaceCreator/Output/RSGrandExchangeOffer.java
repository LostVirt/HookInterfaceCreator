package api.utilities.internal;


public interface RSGrandExchangeOffer {
    int getCurrentPrice();
    int getCurrentQuantity();
    int getId();
    byte getState();
    int getTotalQuantity();
    int getUnitPrice();
}

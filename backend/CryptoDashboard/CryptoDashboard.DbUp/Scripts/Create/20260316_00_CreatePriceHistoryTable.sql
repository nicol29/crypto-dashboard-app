BEGIN;

CREATE TABLE price_history (
    id BIGSERIAL PRIMARY KEY,
    coin_symbol VARCHAR(15) NOT NULL,
    price NUMERIC(18,8) NOT NULL,
    price_change NUMERIC(18,8) NOT NULL,
    price_change_percent NUMERIC(8, 4) NOT NULL,
    daily_high NUMERIC(18,8) NOT NULL,
    daily_low NUMERIC(18,8) NOT NULL,
    volume NUMERIC(20,2) NOT NULL,
    recorded_at TIMESTAMPTZ NOT NULL
);

COMMIT;
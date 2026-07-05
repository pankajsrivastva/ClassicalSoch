CREATE OR REPLACE PROCEDURE sp_insert_inquiry(
    p_name VARCHAR(150),
    p_mobile VARCHAR(20),
    p_email VARCHAR(150),
    p_gender VARCHAR(20),
    p_interested_in VARCHAR(100),
    p_package_name VARCHAR(150),
    p_preferred_date DATE,
    p_message TEXT
)
LANGUAGE plpgsql
AS $$
BEGIN
    INSERT INTO inquiries(name, mobile, email, gender, interested_in, package_name, preferred_date, message, status)
    VALUES (p_name, p_mobile, p_email, p_gender, p_interested_in, p_package_name, p_preferred_date, p_message, 'pending');
END;
$$;

CREATE OR REPLACE PROCEDURE sp_get_packages_by_filter(
    p_category VARCHAR(50),
    p_search VARCHAR(100)
)
LANGUAGE plpgsql
AS $$
BEGIN
    SELECT id, package_name, category, original_price, discount_price, discount_percentage, description, duration, validity, suitable_for, featured, popular, offer_label, display_sequence, status, seo_url, image_name
    FROM packages
    WHERE (p_category IS NULL OR p_category = '' OR category = p_category)
      AND (p_search IS NULL OR p_search = '' OR package_name ILIKE '%' || p_search || '%' OR description ILIKE '%' || p_search || '%');
END;
$$;

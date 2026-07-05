INSERT INTO site_settings(site_name, phone, address, email, instagram_url, facebook_url, whatsapp_url, youtube_url)
VALUES ('The Classical Soch', '7484994456', 'Gherai More Andar, Siwan, Bihar, India', 'hello@classicalsoch.com', 'https://instagram.com', 'https://facebook.com', 'https://wa.me/917484994456', 'https://youtube.com')
ON CONFLICT DO NOTHING;

INSERT INTO packages(package_name, category, original_price, discount_price, discount_percentage, description, duration, validity, suitable_for, featured, popular, offer_label, image_name, display_sequence, status, seo_url)
VALUES
('Signature Glow', 'Women', 3500, 3000, 14, 'A luxurious glow treatment for special occasions.', '60 mins', '30 days', 'Women', TRUE, TRUE, 'Limited Offer', 'package1.jpg', 1, 'active', 'signature-glow'),
('Royal Hair Spa', 'Men', 2200, 1800, 18, 'Relaxing spa therapy with premium scalp care.', '45 mins', '30 days', 'Men', FALSE, TRUE, 'Popular', 'package2.jpg', 2, 'active', 'royal-hair-spa'),
('Bridal Deluxe', 'Bridal', 8500, 7200, 15, 'Elegant bridal styling crafted to perfection.', '180 mins', '90 days', 'Bridal', TRUE, TRUE, 'Bridal Special', 'package3.jpg', 3, 'active', 'bridal-deluxe');

INSERT INTO services(service_name, category, price, duration, description, image_name, display_sequence, status)
VALUES
('Hair Cut', 'Men', 650, '45 mins', 'Precision haircuts with luxury finishing.', 'hair-cut-men.jpg', 1, 'active'),
('Facial', 'Women', 1500, '60 mins', 'Hydrating and rejuvenating facial treatment.', 'facial.jpg', 2, 'active'),
('Hair Color', 'Women', 2100, '90 mins', 'Premium hair color and shine restoration.', 'hair-color.jpg', 3, 'active');

INSERT INTO courses(course_name, duration, fees, description, image_name, display_sequence, status)
VALUES
('Professional Makeup Course', '3 months', 18000, 'Learn bridal and editorial makeup.', 'course1.jpg', 1, 'active'),
('Hair Styling & Coloring Course', '4 months', 22000, 'Master salon hair techniques.', 'course2.jpg', 2, 'active');

INSERT INTO faqs(question, answer, display_sequence, status)
VALUES
('Do you offer bridal makeup?', 'Yes, our bridal specialists offer premium services for weddings and events.', 1, 'active'),
('Can I book an academy course?', 'Yes, you can apply directly through our contact form or phone.', 2, 'active');

INSERT INTO gallery_items(image_name, category, display_sequence, status)
VALUES
('gallery1.jpg', 'Salon', 1, 'active'),
('gallery2.jpg', 'Bridal', 2, 'active');

INSERT INTO admin_users(username, password_hash, full_name)
VALUES ('admin', '$2b$12$0K2pXqj5oJv5C95C0qVQkOz2qSJY8l7Zf6fJ0ofu5lMaK2Q2i4p5m', 'Administrator');

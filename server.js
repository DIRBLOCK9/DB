const express = require('express');
const app = express();
const path = require('path');

// Для обробки POST-запитів у форматі JSON
app.use(express.json());

// Вказуємо Express обслуговувати статичні файли з папки public
app.use(express.static(path.join(__dirname, 'public')));

// Обробка POST-запиту
app.post('/submit-message', (req, res) => {
    const { name, message } = req.body;
    console.log(`Received message from ${name}: ${message}`);

    // Відповідь серверу
    res.json({ response: `Hello ${name}, your message was received!` });
});

// Запуск сервера на порту 3000
app.listen(3000, () => {
    console.log('Server running at http://localhost:3000');
});

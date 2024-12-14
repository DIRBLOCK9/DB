document.getElementById('message-form').addEventListener('submit', function(event) {
    event.preventDefault();

    const name = document.getElementById('name').value;
    const message = document.getElementById('message').value;

    const data = {
        name: name,
        message: message
    };

    fetch('/submit-message', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(data)
    })
    .then(response => response.json())
    .then(data => {
        document.getElementById('server-response').textContent = `Server Response: ${data.response}`;
    })
    .catch((error) => {
        console.error('Error:', error);
    });
});

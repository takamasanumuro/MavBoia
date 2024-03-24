Multithreaded application to receive custom Mavlink messages via a USB radio connected to a serial port or by HTTP requisitions.

Data is exchanged via MAVLink, which is a binary protocol created for radio transmission that minimizes overhead and offers
checksums for error detection. A custom dialect for our boat was created using the Python Mavgen utility.
Message handling and UI run on different threads in order to not block each other. Keep in mind there are special methods that must
be used to handle communication between distinct threads, such as invoking delegates.

TODO:
--Improve data logging
--Improve camera support
--Make the app fullscreen
--Create graphical form to show the data
--Reduce coupling between components
--Reduce hardcoding, save and load configurations by file
--Refactor application to use MVP pattern
--Use a faster MAVLink library ( app crashes when receiving too many messages, such as trying to connect to a Pixhawk)
--Make it easier to generate our custom Mavlink dialect.
--Improve documentation, create UML diagrams

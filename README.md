# DDNS_updater
This project aims to update users IP address on dynamic DNS provider No-IP.

Using this software, you can update your public IP on no-ip.com periodically. This application can use two methods for updating the IP address:
1) Sending the IP directly to no-ip.com using a Get request like below:

GET /nic/update?hostname=mytest.example.com&myip=192.0.2.25 HTTP/1.1
Host: dynupdate.no-ip.com
Authorization: Basic base64-encoded-auth-string
User-Agent: Company DeviceName-Model/FirmwareVersionNumber maintainer-contact@example.com

2) Using a third-party website for sending the IP by exploiting a piece of php code to send the information as follows:
http://username:password@dynupdate.no-ip.com/nic/update?hostname=mytest.example.com&myip=192.0.2.25


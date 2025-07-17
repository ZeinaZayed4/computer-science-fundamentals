# Protocol Stack and Security

## Protocol "Layers"
- Networks are complex, with many "pieces":
  - hosts.
  - routers.
  - links of various media.
  - applications.
  - protocols.
  - hardware, software.

## Why Layering?
- Dealing with complex systems:
  - explicit structure allows identification, relationship of complex system's pieces
    - layered _reference model_ for discussion.
  - modularization eases maintenance, updating system.
    - change of implementation of layer's service is transparent to the rest of the system.
    - e.g., change in gate procedure doesn't affect the rest of the system.
  - layering considered harmful?

## Internet Protocol Stack
- **Application**:
  - supporting network applications
    - FTP, SMTP, HTTP.
- **Transport**:
  - process-process data transfer
    - TCP, UDP.
- **Network**:
  - routing of datagrams from source to destination.
    - IP routing protocols.
- **Link**:
  - data transfer between neighboring network elements.
    - Ethernet, 802.111 (Wi-Fi), PPP.
- **Physical**:
  - bits "on the wire."

## ISO/OSI Reference Model
- **Presentation**:
  - allow applications to interpret the meaning of data, e.g., encryption, compression, machine-specific conventions.
- **Session**:
  - synchronization, checkpointing, recovery of data exchange.
- Internet stack "missing" these layers!
  - these services, _if needed_, must be implemented in application.

## Network Security
- Field of network security:
  - how bad guys can attack computer networks?
  - how can we defend networks against attacks?
  - how to design architectures that are immune to attacks?
- Internet not originally designed with (much) security in mind.
  - original vision: "a group of mutually trusting users attached to a transparent network."
  - Internet protocol designers playing "catch-up."
  - security considerations in all layers.

### Bad Guys: Put Malware into Hosts via Internet
- Malware can get in host from:
  - virus: self-replication infection by receiving/executing an object (e.g., e-mail attachment).
  - worm: self-replication infection by passively receiving object that gets itself executed.
- Spyware malware can record keystrokes, websites visited, upload info to collection site.
- Infected host can be enrolled in _botnet_, used for spam. DDoS attacks.

### Bad Guys: Attack Server, Network Infrastructure
- Denial of Service (DoS):
  - attackers make resources (server, bandwidth) unavailable to legitimate traffic by overwhelming resource with bogus traffic.
1. Select target.
2. Break into hosts around the network (see botnet).
3. Send packets to target from compromised hosts.

### Bad Guys Can Sniff Packets
- Packet "sniffing":
  - broadcast media (shared Ethernet, wireless).
  - promiscuous network interface reads/records all packets (e.g., including passwords!) passing by.
  - wireshark software is a (free) packet-sniffer.

### Bad Guys Can Use Fake Addresses
- IP spoofing: send a packet with false source address.

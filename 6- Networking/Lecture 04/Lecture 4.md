# Delays and Performance

## How do Loss and Delay Occur?
- Packets queue in router buffers
  - packet arrival rate to link (temporarily) exceeds output link capacity.
  - packet queue, wait for turn.

## Four Sources of Packet Delay
- **d<sub>nodal</sub> = d<sub>proc</sub> + d<sub>queue</sub> + d<sub>trans</sub> + d<sub>prop</sub>**
- d<sub>proc</sub>: nodal processing
  - check bit errors.
  - determine output link.
  - typically < msec.
- d<sub>queue</sub>: queueing delay
  - time waiting at the output link for transmission.
  - depends on the congestion level of the router.
- d<sub>trans</sub>
  - L: packet length (bits).
  - R: link bandwidth (bps).
  - d<sub>trans</sub> = L/R. 
- d<sub>prop</sub>: propagation delay
  - d: length of the physical link.
  - s: propagation speed (~2x10<sup>8</sup> m/sec)
  - d<sub>prop</sub> = d/s.
- d<sub>trans</sub> and d<sub>prop</sub> are very different.

## "Real" Internet Delays and Routes
- What do "real" internet delay and loss look like?
- traceroute program: provides delay measurement from source to router along an end-end internet path towards destination.
  - For all i:
    - sends three packets that will reach the router i on path towards destination.
    - router i will return packets to sender.
    - sender times interval between transmission and reply.
- ![test 1](img.png)
- ![test 2](img_1.png)

## Throughput
- rate (bits/time unit) at which bits transferred between sender/receiver.
  - instantaneous: rate at a given point in time.
  - average: rate over longer period of time.
- Bottleneck link:
  - link on end-end path that constraints end-end throughput.

### Throughput: Internet Scenario
- pre-connection end-end throughput: min(R<sub>c</sub>, R<sub>s</sub>, R/10).
- in practice: R<sub>c</sub> or R<sub>s</sub> is often bottleneck.

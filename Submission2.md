<div align="center">
    <img src="./assets/logo.png" width="290">
    <p><b>MScFE 670 Data Feeds and Technology<br>
    Group Work Assignment</b><br>
    April 27, 2020</p>
    <i>
    Aaron Jones - <a href="mailto:aspcul8r@gmail.com">aspcul8r@gmail.com</a><br>
    Gustavo Campos - <a href="mailto:gustavoc82@me.com">gustavoc82@me.com</a><br>
    Mahsa Kiani - <a href="mailto:mahsa.kiani@ieee.org">mahsa.kiani@ieee.org</a><br>
    Jared Marks - <a href="mailto:jared.marks@live.com">jared.marks@live.com</a>
    </i>
    <p></p>
    <p><b>Abstract</b></p>
</div>
In this article...<br>
<p></p>
<b><i>Keywords:</i></b> ...
<p></p>

# Introduction

...

# Key Concepts in Blockchain Technologies

The purpose of this submission is to explore different blockchain platforms in order to understand the solutions available in the market today and, more importantly, to solidify your understanding of the key concepts of blockchains.

As a starting point to compare different blockchain technologies, use Module 5: Cryptocurrencies course notes as well as the notes below on settlement finality.

_Settlement Finality: Payments Perspective_

Much of the interest around blockchain, particularly Bitcoin, is its potential role as a payments system. As such, it is worth considering the concept of settlement finality for each of these technologies.

At a high-level, settlement finality refers to the concept of a payment being irrevocable – i.e. once a payment is made, and settled, it cannot be reversed. Interestingly, this is particularly important in the prevention of bank runs. Let’s consider a more relevant example around what settlement finality is by looking at Bitcoin.

Bitcoin uses a proof-of-work consensus algorithm, which relies on miners sorting transactions into blocks, and timestamping them. However, should 51% of the network choose to, it is possible to go back and re-mine the chain. As such, Bitcoin has a probabilistic settlement. Essentially, it is always theoretically possible that a payment can be reversed. (Of course, this possibility decreases significantly with chain length and the number of miners.)

See the following reference: https://www.mangoresearch.co/settlement-finality-pow-posblockchain/ for a more detailed explanation.

For this submission, your task is to describe and compare the key concepts of different blockchain technologies:

1. Bitcoin
2. Ethereum
3. Hyperledger
4. Corda

For each of the technologies above, discuss the following:

1. _Scalability_ – i.e. the ability for the system to process transactions.
2. _Consensus protocol_ – i.e. how the network reaches a state of consensus or how the integrity of the ledger is maintained.
3. _Privacy_ – i.e. the degree to which users and transactions are private.
4. _Degree of decentralization_ – i.e. whether there are central points of failure or authority.
5. _Settlement finality_ – i.e. whether transactions are truly final and irrevocable.

Write a report of 1-2 pages for each of the points above.

## Bitcoin

### Scalability

### Consensus protocol

### Privacy

### Degree of decentralization

### Settlement finality

## Ethereum

### Scalability

### Consensus protocol

### Privacy

### Degree of decentralization

### Settlement finality

## Hyperledger

Hyperledger is focused on the adaptation of blockchain technology for common business transactions and is encouraging open source development in a broad array of use directions via frameworks. The backbone of the tech is not concerned with valuations and can potentially transact in any currency which would allow broad and immediate industry application. The concept of open source development in blockchain technology was put forth by a consortium of industry groups that sees the applicability of transaction in day to day, end-to-end business and data transactions. Management of open source development has been given to the Linux Foundation which currently sports six production stable technologies: Hyperledger Fabric, Indy,  Iroha, Burrow and Sawtooth. 

### Scalability

Various hyperledger frameworks are built around use case scenarios that include plug-and-play style modulation for extensibility. Thus, scalability is not necessarily measured on the applicability of hyperledger to all forms of possible transactions, but rather in terms of best fit for a particular industry niche which will ultimately be limited in scope. It is the flexibility of modular application that ultimately determines scalability of the chosen architecture. 

### Consensus protocol

The branching development of hyperledger allows for the adaptive modulation of a variety of consensus protocols. As hyperledger was created for business transactions that incorporate some level of trust between participants and maximize the need for expedience with efficacy, the Proof of Work protocol employed by Bitcoin has been left off of the development table. From a high level, that leaves lottery and voting methods which employ private, permission based protocols for extensibility in the various hyperledger frameworks as seen through Kafka, RBFT, Sumeragi, and PoET. The latter of the extensions, as seen in the Sawtooth framework, is the only protocol using a lottery methodology while the others use voting. Ultimately, consensus is reached after meeting criteria set in a smart contract which contains the logic or rules defining validity (Hyperledger Architecture Working Group 2017).

### Privacy

Encryption across the hyperledger blockchain requires end to end cryptographic keys held by participants. It is possible to mask transaction origination but ultimate privacy with hyperledger lay with the construct of use, interaction with other legacy information systems, and user interaction protocols. It is possible for a user to supply traceable information with a transaction that can ultimately reveal their complete transaction history (Hyperledger Blog 2017).

### Degree of decentralization

Like the question of scalability, the level of centralization or decentralization of hyperledger is dependent upon the modules that are chosen to complete the architecture within a specific framework. Unlike blockchain resources that power public transactions, the private permissed nature of hyperledger would suggest private ownership of transactional nodes, so market participants could ultimately choose the degree of decentralization that fits their needs.

### Settlement finality

Transaction finality is based on the consensus protocol being employed. If voting methodologies are employed in the protocol, finality is instantaneous with the conclusion of transaction processing. Lottery based methodologies require a consensus state across nodes that are determining commitment with probability.  Although the difficulties of lottery are usually avoided in Hyperledger private, permission based uses, circumstances could arise with untrusted nodes where finality consensus is delayed or frozen (PSWG 2018).

## Corda

### Scalability

### Consensus protocol

### Privacy

### Degree of decentralization

### Settlement finality

# Conclusion

...@

# References

Hyperledger Architecture Working Group (WG). 2017. Hyperledger Architecture, Volume 1. https://www.hyperledger.org/wp-content/uploads/2017/08/Hyperledger_Arch_WG_Paper_1_Consensus.pdf

Hyperledger Blog. 2017. Q&A: Does blockchain alleviate security concerns or create new challenges? https://www.hyperledger.org/blog/2017/10/17/qa-does-blockchain-alleviate-security-concerns-or-create-new-challenges

Performance and Scale Working Group, 2018. Hyperledger Blockchain Performance Metrics. 
https://www.hyperledger.org/wp-content/uploads/2018/10/HL_Whitepaper_Metrics_PDF_V1.01.pdf

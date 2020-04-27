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

Corda is an open-source blockchain platform developed by R3. The goal of Corda is to provide building blocks for distributed applications in the areas of finance and business, specifically when it comes to agreements, documents, and other data where two parties would like to maintain accurate, up to date versions of the same data.

Corda has been open-source since 2016 and has seen adoption by governments, central banks, and financial institutions as a way to track transactions in a scalable, private, and decentralized manner. Despite the blockchain connection however, Corda differs from other technologies such as Bitcoin and Ethereum in the sense that there is no chain of blocks but rather a distributed database technology to manage the state of transactions.

Corda's design favors use cases where the parties involved in a transaction trust each other, but not enough to allow the counterparty to maintain all of the records. Corda allows counterparts to have a definite, robust understanding of the state of an agreement or other data at any given time.

### Scalability

One attribute that makes Corda unique is it's ability to scale. This is a direct consequence of the consensus protocol used to verify transactions, but at the expense of some transparency (corda.net). In a traditional blockchain system, each node must verify each transaction, thus the chain is constrained by the weakest link. However, each node in the Corda system does not see each transaction. In fact, the transactions are distributed amongst the nodes, allowing for much greater throughput. 

However, there is a weakness to this type of distribution that ultimately hurts scalability. In the event that an asset has a very long history of transactions associated with it, a node that is required to process this transaction for the first time must verify each proceeding transaction. This can lead to very long delays before the transaction can be verified.

As a result, Corda may be best suited for use in assets that are not expected to be transacted many times in their life, like a contract or debt offering. 

### Consensus protocol

Another attribute that makes Corda unique is its approach to consensus. Corda uses two different types of consensus to verify transactions to the ledger; validity and uniqueness consensus. 

Validity consensus is centered around the idea of making sure that a given transaction is sound and that both parties have properly signed the transaction. As previously mentioned, for a transaction to be valid, each proceeding transaction must also be verified. Thus, the full history of the transaction must be verified in order to add this transaction to the chain. If all prior transactions are properly signed and the current addition to the transaction is also properly signed, it is a candidate for validation and addition to the ledger.

Secondly, uniqueness consensus helps prevent against the common "double spend" issue of trying to get transactions verified at the same time in order to cheat the system. Uniqueness consensus helps prevent this by checking to make sure that the inputs for a transaction have not already been used in another transaction This process is aided by what are called *notaries*, which is a network cluster that verifies the uniqueness property of the transaction. Until the notary verifies the transaction and adds its signature, the transaction will not be seen as valid. In regards to algorithms, the notary can be a single node, a group of nodes, and can implement whichever consensus algorithm it chooses. 

If both the validity and uniqueness checks hold, the transaction can be verified and added to the ledger.

### Privacy

The development team at R3 believes that mechanisms within Corda make it private for most use cases, however, one can argue that there are still gaps similarly suffered by other blockchain implementations. In terms of privacy, one advantage of Corda is that nodes do not see all transactions, which makes transactions more private than other blockchains. However, the big concern is that since nodes must verify preceding transactions, privacy can be a concern later in the lifecycle of an asset. As an example, if person A and person B make a transaction, and then person B later transacts with person C, the node will have all of this information. However there is no way for person A to know who may see the transaction later on. The Corda team has researched possible solutions to this problem, for example using multiple public keys (white paper).

Similarly, Corda is not trustless and a party's identity must be known prior to joining a network (corda.net). As a result, it is really not possible to transact anonymously on Corda, although in the future it may be possible.

### Degree of decentralization

In a Corda network, each node runs the Corda software and other applications called CorDapps. Corda's design is such that the network is decentralized, governed by smart contracts in such a way that transactions are not valid until signed and verify by the parties involved (Greenspan). However, even the R3 team admits that Corda is not quite as decentralized as other systems like Bitcoin or Ethereum due to its non-trustless nature and the fact that transactions are not verified by the entire network (corda.net). However, it is pointed out that this is a design choice favoring speed and scalability. Thus, users of Corda should be aware of it's limitations and potential flaws but understand the gains in performance. Regardless, Corda should provide enough transparency, privacy, and protection for most use cases.

### Settlement finality

Like most distributed ledger technologies, most transactions are final and cannot be reversed. The same is true of Corda where once a transaction is deemed valid, it cannot be reversed. Plus, the consensus protocols in place help avoid invalid transactions such as "double spending" which would cause the need for a transaction to be reversed. Due to these mechanisms, it is unlikely that an invalid transaction would be signed and later verified as a valid transaction.

# Conclusion

...@

# References
The Corda Platform: An Introduction. Corda.net, 2018, The Corda Platform: An Introduction.

Greenspan, Gideon. R3 Corda: Deep Dive and Technical Review. Multichain.com, R3 Corda: Deep Dive and Technical Review.

“Open Source Blockchain Platform for Business.” Corda, www.corda.net/.

Hyperledger Architecture Working Group (WG). 2017. Hyperledger Architecture, Volume 1. https://www.hyperledger.org/wp-content/uploads/2017/08/Hyperledger_Arch_WG_Paper_1_Consensus.pdf

Hyperledger Blog. 2017. Q&A: Does blockchain alleviate security concerns or create new challenges? https://www.hyperledger.org/blog/2017/10/17/qa-does-blockchain-alleviate-security-concerns-or-create-new-challenges

Performance and Scale Working Group, 2018. Hyperledger Blockchain Performance Metrics. 
https://www.hyperledger.org/wp-content/uploads/2018/10/HL_Whitepaper_Metrics_PDF_V1.01.pdf

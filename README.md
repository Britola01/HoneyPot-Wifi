Funcionalidade Basica ⤵

A ferramenta opera configurando um ponto de acesso falso que parece uma rede legítima. O objetivo é fazer com que atacantes ou usuários mal-intencionados tentem se conectar a essa rede, revelando suas atividades.

-> Configuração de Rede Wi-Fi Falsa:

 *Utilizamos o hostapd, um software amplamente usado para configurar pontos de acesso sem fio no Linux. O hostapd permite configurar a placa de rede Wi-Fi para agir como um ponto de acesso, especificando o SSID (nome da rede), a criptografia utilizada, e outras configurações relevantes.
 
-> Monitoramento de Atividades:

 *O sistema monitora qualquer tentativa de conexão à rede Wi-Fi falsa. Ao se conectar, tentativas de autenticação e outras atividades são registradas, incluindo o endereço MAC do dispositivo que tenta se conectar e quaisquer dados que ele envia durante a tentativa de autenticação.
 

A ferramenta pode ser implementada ou utilizada da forma que necessitar. (Testada apenas em ambientes Linux).

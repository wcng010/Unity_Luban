# Unity_Luban
 粗略读过Luban教程和源码后，发现它创建的数据类似乎不支持Json的写入（官方说是在更新），干脆在它的Excel->JSon->cs读取文件流程在加一步，将Excel文件直接转换为ScriptObject存储。相当于一个Excel到ScriptObject的自动转换器。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InventarioListaSimple
{
    class Inventario
    {
        private Producto Primero;
        private Producto Ultimo;
        int contador = 0;

        public Inventario()
        {
            Primero = null;
            Ultimo = null;
        }

        /// <summary>
        /// Recibe productos y los ordena de forma ascendiente de acuerdo 
        /// al código del prodcuto
        /// </summary>
        /// <param name="nuevo"></param>
        public void agregarOrdenado(Producto nuevo)
        {
            Producto guardar = Primero;

            if (buscarInicio(nuevo.codigo) == false)     //cuando es false quiere decir que no hay aun ese codigo y lo deja agregar a la lista
            {
                if (Primero == null)                       
                {
                    Primero = nuevo;
                }
                else 
                {
                    if(nuevo.codigo < Primero.codigo)   
                    {
                        nuevo.Siguiente = Primero;           
                        Primero = nuevo;
                    }
                    else if(nuevo.codigo > Primero.codigo)       
                    {
                        while(guardar.Siguiente != null && nuevo.codigo > guardar.Siguiente.codigo)   //este sirve para indicarnos cuando dos numeros estan
                        {                                                                             //enseguida uno con el otro, cuando se cumple se sale del
                            guardar = guardar.Siguiente;                                             //while para entrar a lo de abajo donde se cambian las direcciones del siguiente de cada uno
                        }
                        nuevo.Siguiente = guardar.Siguiente;
                        guardar.Siguiente = nuevo;
                    }
                }
                contador++;
            }
        }


        public void agregarProducto(Producto nuevo)
        {
            if(buscarInicio(nuevo.codigo) == false)     //cuando es false quiere decir que no hay aun ese codigo y lo deja agregar a la lista
            {
                if (Primero == null)
                    Primero = nuevo;
                else
                    agregarProducto(Primero, nuevo);
                contador++;

            }

        }


        private void agregarProducto(Producto ultimo, Producto nuevo )
        {
            if (ultimo.Siguiente == null)
                ultimo.Siguiente = nuevo;
            else
                agregarProducto(ultimo.Siguiente, nuevo);

        }

        /// <summary>
        /// Recibe un producto y lo coloca al inicio de la lista
        /// </summary>
        /// <param name="nuevo"></param>
        public  void agregarEnInicio(Producto nuevo)
        {
            if (buscarInicio(nuevo.codigo) == false)     //cuando es false quiere decir que no hay aun ese codigo y lo deja agregar a la lista
            {
                Producto Actual = Primero;
                Primero = nuevo;
                Primero.Siguiente = Actual;
                contador++;
            }

        }

        /// <summary>
        /// Método con el cual nos sirve verificar si ya existe un código y 
        /// este método lo maneja en gran parte el form 
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public bool buscarInicio(int codigo)
        {
            bool mostrar = false;
            Producto Actual = Primero;
            bool encontrado = false;

            while (Actual != null && encontrado != true)
            {
                if (Actual.codigo == codigo)
                {
                    mostrar = true;
                    encontrado = true;
                }
                Actual = Actual.Siguiente;
            }

            return mostrar;
        }

        /// <summary>
        /// Método con el cual nos sirve verificar si una posición podría existir y 
        /// este método lo maneja sobretodo el form
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public bool buscarInicioPos(int pos)
        {
            bool mostrar = false;
            if(pos <= contador)
                mostrar = true;
            return mostrar;
        }


        #region          métodos con posición del producto

        public void insertarPosicion(Producto nuevo, int posicion)
        {
            Producto Actual = Primero;
            Producto temporal = null;

            if (buscarInicio(nuevo.codigo) == false)     //cuando es false quiere decir que no hay aun ese codigo y lo deja agregar a la lista
            {

                if (Primero != null)
                {
                    if (posicion == 1)
                    {
                        agregarEnInicio(nuevo);
                    }
                    else
                    {
                        for (int i = 1; i < (posicion - 1); i++)
                        {
                            Actual = Actual.Siguiente;
                        }
                        temporal = Actual.Siguiente;
                        Actual.Siguiente = nuevo;
                        nuevo.Siguiente = temporal;
                        contador++;
                    }
                }
                else
                    MessageBox.Show("Error, lista vacia");
            }
        }


        public void eliminarProductoPos(int posicion)
        {
            Producto Actual = Primero;
            Producto temporal = null;

            if (Primero != null)
            {
                if (posicion <= contador && posicion > 0)
                {
                    if (posicion == 1)
                    {
                        Primero = Primero.Siguiente;
                        contador--;
                    }
                    else
                    {
                        for (int i = 1; i < (posicion - 1); i++)
                        {
                            Actual = Actual.Siguiente;
                        }
                        temporal = Actual.Siguiente;
                        Actual.Siguiente = temporal.Siguiente;
                        contador--;
                    }
                }

            }
            else
                MessageBox.Show("Error, lista vacia");

        }


        public Producto buscarProductoPos(int posicion)
        {
            Producto mostrar = null;
            Producto Actual = Primero; 

            if (Primero != null)
            {
                if (posicion <= contador && posicion > 0)
                {
                    if (posicion == 1)
                        mostrar = Primero;

                    else
                    {
                        for (int i = 1; i < posicion; i++)
                        {
                            Actual = Actual.Siguiente;
                        }
                        mostrar = Actual;
                    }
                }

            }
            else
                MessageBox.Show("Error, lista vacia");
      
            return mostrar;
        }



        #endregion


        #region           métodos con código del producto

        public void insertarCodigo(Producto nuevo, int codigo)
        {
            Producto Actual = Primero;
            Producto temporal = null;

            bool encontrado = false;

            if (buscarInicio(nuevo.codigo) == false)
            {

                if (Primero != null)
                {
                    while (Actual != null && encontrado != true)
                    {
                        temporal = Actual.Siguiente;

                        if (Actual.codigo == codigo)
                        {
                            Actual.Siguiente = nuevo;
                            nuevo.Siguiente = temporal;
                            encontrado = true;
                        }
                        else
                        {
                            Actual = Actual.Siguiente;
                        }
                    }
                }
                else
                    MessageBox.Show("Error, lista vacia");

            }
        }


        public Producto buscarProductoCod(int codigo)
        {
            Producto mostrar = null;
            Producto Actual = Primero;    //aqui indico que el el producto actual empieza con el primer elemento que tengo, me sirve para recorrer la lista
            bool encontrado = false;            //sirve para indicarme cuando el codigo coincida con el que busco

            if (Primero != null)   //con este me dice que la lista si contiene algo dentro
            {
                while (Actual != null && encontrado != true)
                {
                    if (Actual.codigo == codigo)
                    {
                        mostrar = Actual;
                        encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }

                if (encontrado == false)
                {
                    mostrar = null;
                }
            }
            else
                MessageBox.Show("Error, lista vacia");

            return mostrar;
        }


        public void eliminarProductoCod(int codigo)
        {
            Producto Actual = Primero;
            Producto temporal = null;

            bool encontrado = false;

            // primero=100          ultimo=89           Actual=89           anterior=47         codigo=100      encontrado=false

            //  listaSimple         56 -> 100 -> 47 -> 89 -> null

            if (Primero != null)
            {
                while (Actual != null && encontrado != true)
                {
                    if (Actual.codigo == codigo)
                    {
                        if (Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                        }
                        else if (Actual == Ultimo)
                        {
                            temporal.Siguiente = null;
                            Ultimo = temporal;
                        }
                        else
                        {
                            temporal.Siguiente = Actual.Siguiente;
                        }

                        encontrado = true;
                    }
                    temporal = Actual;
                    Actual = Actual.Siguiente;
                }

            }
            else
                MessageBox.Show("Error, lista vacia");

        }
        #endregion


        public string reporteVolteado()
        {
            string mostrar = "";

            if (Primero.Siguiente == null)
                mostrar += Primero.ToString();
            else
                mostrar = reporteVolteado(Primero.Siguiente) + "\r\n" + Primero.ToString();
            return mostrar;

        }


        private string reporteVolteado(Producto nuevo)
        {
            string mostrar = "";
            if (nuevo.Siguiente != null)
                mostrar +=  reporteVolteado(nuevo.Siguiente) + "\r\n" + nuevo.ToString();
            else
                mostrar += nuevo.ToString();
            return mostrar;
        }


        public string reporte()
        {
            string mostrar = "";
            Producto Actual = Primero;
            
            if(Actual != null)           
            {
                while(Actual != null)
                {
                    mostrar += Actual.ToString() + "\r\n";
                    Actual = Actual.Siguiente;
                }
            }
            else
                mostrar = "La lista no contiene elementos disponibles";
            
            return mostrar;
        }


    }

}

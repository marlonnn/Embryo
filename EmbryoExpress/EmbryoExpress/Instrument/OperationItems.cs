using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbryoExpress.Instrument
{
    public class OperationItems : BaseInstrument
    {
        public OperationItems()
        {

        }

        public OperationItems(string operators, OperationType operatorType, int operationNumber, OperationResult operationResult)
        {
            this.operators = operators;
            this.operationResult = OperationResult;
            this.operationNumber = operationNumber;
            this.operationResult = operationResult;
        }
        private string operators;
        public string Operator
        {
            get { return this.operators; }
            set { this.operators = value; }
        }

        private OperationType operatorType = OperationType.UnKnown;
        public OperationType OperatorType
        {
            get { return this.operatorType; }
            set { this.operatorType = value; }
        }

        private int operationNumber;
        public int OperationNumber
        {
            get { return this.operationNumber; }
            set { this.operationNumber = value; }

        }

        private OperationResult operationResult = OperationResult.UnKnown;
        public OperationResult OperationResult
        {
            get { return this.operationResult; }
            set { this.operationResult = value; }
        }
    }
}
